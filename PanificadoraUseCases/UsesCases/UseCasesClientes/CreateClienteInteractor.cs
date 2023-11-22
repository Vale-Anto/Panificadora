using ClientesPedidos.ObjetoNegocio.DTOs.ClienteDTOs;
using ClientesPedidos.ObjetoNegocio.DTOs.ValidaciónDTO;
using ClientesPedidos.ObjetoNegocio.Interfaces.Getways.InputPort;
using ClientesPedidos.ObjetoNegocio.Interfaces.Presentadores.ClientesPrecenters;
using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;
using CRUD.Entidades.Entidaddes;
using CRUD.Entidades.Interfaces.Repositorio;
using CRUD.PanificadoraUseCases.Especificaciones.EspecificaciónCliente;

namespace PanificadoraUseCases.UsesCases.UseCasesClientes
{
    public class CreateClienteInteractor : ICreateClienteInputPort
    {
        readonly IClienteRepository _repository;
        readonly ICreateClientePresenters _presenters;


        public CreateClienteInteractor(IClienteRepository repository, ICreateClientePresenters presenters)
        {

            _repository = repository;
            _presenters = presenters;

        }

        public async Task Handle(CrearSolicitudCliente crearSolicitudCliente)
        {
            List<ValidaciónErrorDTO> errors = new();
            errors = ValidateCliente(crearSolicitudCliente);
            CreateDeleteClienteResponse clienteResponse = new();

            if (errors.Any())
            {
                clienteResponse.ValidationErrors = errors;
                await _presenters.Handle(clienteResponse);
                return;
            }

            Cliente newCliente = new()
            {
                Nombre = crearSolicitudCliente.Nombre
            };
            try
            {
                await _repository.AddCliente(newCliente);
                await _repository.SaveChange();
                clienteResponse.IdCliente = newCliente.Id;
            }
            catch (Exception ex)
            {
                clienteResponse.ErrorNumber = 500;
                clienteResponse.MenssageError = $"Se produjo un error al guarar los datos. {ex.Message}";
            }
            finally
            {
                await _presenters.Handle(clienteResponse);
            }
        }

        private List<ValidaciónErrorDTO> ValidateCliente(CrearSolicitudCliente crearSolicitudCliente)
        {
            var Specification = new CreateClienteSpecifications(crearSolicitudCliente);
            return Specification.IsValid();
        }
    }
}
