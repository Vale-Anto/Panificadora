
using Panificadora.BusinessObject.DTOs.PedidoDTOs;
using Panificadora.BusinessObject.Interfaces.Controllers;
namespace Panificadora.WebApi.Controllers
{
    public static class DeletePedidoEndPoint
    {
        public static WebApplication BorrarPedido(this WebApplication app)
        {
            app.MapPut("/borrarpedido/{id}", async (IDeletePedidoController controller, int id) =>
            {
                var pedido = await controller.DeletePedido(id);
                if (pedido == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
                else if (pedido.ErrorNumber != 0 && !string.IsNullOrEmpty(pedido.Message))
                {
                    return Results.BadRequest(pedido);
                }
                return Results.Ok(pedido);
            });
            return app;
        }
    }
}

