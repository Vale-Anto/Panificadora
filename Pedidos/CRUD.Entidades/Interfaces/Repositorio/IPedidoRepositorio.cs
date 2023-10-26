using Panificadora.Core.Entidades;


namespace Panificadora.Core.Interfaces.Repositorio
{
    public interface IPedidoRepositorio : IUnitOfWork <PedidoEntidad>
    {
        
        Task<List<PedidoEntidad>> GetAllPedidoRepositorio();

    }
}

//acá están las tareas que va a realizar, GetBy devolver un objeto del tipo pedido que es la entidad, va
//a buscar un elemento por su id (que se lo voy a pasar yo) ycuando lo encuentre lo va a devolver encapsulado en una entidad 
//pedido - Create para crear un elemento, yo le voy a mandar un objeto del tipo Pedido y la tarea la va a crear - Update actualiza,
//no devuelven nada, hacen la cosa que les digo - Delete lo mismo - GetAll para obtener una lista de todos los registros que coincidan
//con algún método

//las tareas pueden ser task o value task, la diferencia es que el Task puede volver sin haber terminado de hacer las tareas intermedias
// y el value no vuelve hasta que no terminen de ejecutarse todas
//todas las tareas deberian tener un método que se llame guardar (IUnitofWork)
//public interface Pedido : IUnitOfWork, todas las interfaces heredan de esa para tener el método guardar


