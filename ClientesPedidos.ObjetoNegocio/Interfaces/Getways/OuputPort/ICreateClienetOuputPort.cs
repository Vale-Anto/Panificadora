using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Getways.OuputPort
{
    public interface ICreateClienetOuputPort
    {

        Task Handle(CrearClienteResponse cliente);


    }
}
