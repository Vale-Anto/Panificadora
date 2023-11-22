using ClientesPedidos.ObjetoNegocio.DTOs.ClienteDTOs;
using ClientesPedidos.ObjetoNegocio.DTOs.ValidaciónDTO;
using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;
using CRUD.Entidades.Entidaddes;
using CRUD.Entidades.Interfaces.Repositorio;
using PanificadoraUseCases.Especificaciones.EspecificaciónCliente;

namespace PanificadoraUseCases.UsesCases.UseCasesClientes
{
    public class UpdateClienteInteractor : IUpdateClienteInputPort
    {
        private readonly IClienteRepository _repository;
        private readonly IUpdateClientePresenters _presenter;

        public UpdateClienteInteractor(IClienteRepository repository, IUpdateClientePresenters presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(ActualizarSolicitudCliente actualizarSolicitudCliente)
        {
            List<ValidaciónErrorDTO> errors = new List<ValidaciónErrorDTO>();
            ActualizarClientesResponse clienteResponse = new();

            try
            {
                //Valida los datos del clienteResponse a actualizar.
                errors = ValidateCliente(actualizarSolicitudCliente);

                if (errors.Any())
                {
                    // Manejar el caso en el que el clienteResponse no cumpla con las validaciones.
                    // Devuelve un mensaje indicando que los datos del clienteResponse no son validos.
                    clienteResponse.ValidacionErrores = errors;
                    await _presenter.Handle(clienteResponse);
                    return;
                }

                // Obtener el clienteResponse existente por su ID
                Cliente existingCliente = await _repository.GetById(actualizarSolicitudCliente.ClienteId);
                if (existingCliente == null)
                {
                    // Manejar el caso en el que el clienteResponse no existe
                    // Devuelve un mensaje indicando que el clienteResponse no se encontró.
                    clienteResponse.ErrorNumber = 404;
                    clienteResponse.MenssageError = $"El Cliente con {actualizarSolicitudCliente.ClienteId} no existe";
                    await _presenter.Handle(clienteResponse);
                    return;
                }

                // Actualizar la información del clienteResponse con los datos proporcionados
                existingCliente.NombreCliente = actualizarSolicitudCliente.Nombre;

                // Realizar la actualización en el repositorio
                await _repository.UpdateCliente(existingCliente);
                await _repository.SaveChange();

                // Crear un objeto de respuesta exitosa
                clienteResponse.ClienteId = existingCliente.Id;
                clienteResponse.Nombre = existingCliente.NombreCliente;

                // Enviar la respuesta al presentador
                await _presenter.Handle(clienteResponse);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la actualización
                clienteResponse.MenssageError = ex.Message;
            }
            finally
            {
                await _presenter.Handle(clienteResponse);
            }
        }

        private List<ValidaciónErrorDTO> ValidateCliente(ActualizarSolicitudCliente actualizarSolicitudCliente)
        {
            var specification = new UpdateClienteSpecifications(actualizarSolicitudCliente);
            return specification.IsValid();
        }
    }
}
