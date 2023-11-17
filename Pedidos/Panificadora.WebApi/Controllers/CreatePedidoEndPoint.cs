using Microsoft.AspNetCore.Mvc;
using Panificadora.BusinessObject.DTOs.PedidoDTOs;
using Panificadora.BusinessObject.Interfaces.Controllers;

namespace Panificadora.WebApi.Controllers
{
    public static class CreatePedidoEndPoint
    {
        public static WebApplication CrearPedido(this WebApplication app)
        {
            app.MapPost("/crearpedido", async (CreatePedidoRequest request, ICreatePedidoController controller) =>
            {
                var resultado = await controller.CreatePedido(request);

                if (string.IsNullOrEmpty (resultado.Message) || resultado.ValidationDto == null) 
                {
                    return Results.Ok(resultado);
                }
                else
                {
                    return Results.BadRequest(resultado);
                }
            });
            return app;

        }
    }
}
