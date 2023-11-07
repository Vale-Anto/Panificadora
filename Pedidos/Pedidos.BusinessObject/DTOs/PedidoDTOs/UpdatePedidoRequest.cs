
namespace Pedidos.BusinessObject.DTOs.PedidoDTOs
{
    public class UpdatePedidoRequest
    {
        public int Idpedido { get; set; }

        public required string Estado { get; set; }
    }
}

//DTO que se usa para transferir datos de entrada cuando se está actualizando la información
//de un pedido existente
    

