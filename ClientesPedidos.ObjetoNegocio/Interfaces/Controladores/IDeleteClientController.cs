﻿using ClientesPedidos.ObjetoNegocio.Wrappers.Cliente;

namespace ClientesPedidos.ObjetoNegocio.Interfaces.Controladores
{
    public interface IDeleteClientController
    {

        Task<DeleteClientResponse> DeleteCliente(int idCliente);

    }

}
