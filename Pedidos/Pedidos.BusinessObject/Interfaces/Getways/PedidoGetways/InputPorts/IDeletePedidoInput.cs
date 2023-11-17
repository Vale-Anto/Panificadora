namespace Panificadora.BusinessObject.Interfaces.Getways.PedidoGetways
{
    public interface IDeletePedidoInput
    {
        Task Handle(int Idpedido );//elimina un pedido por id
    }
}

    
  