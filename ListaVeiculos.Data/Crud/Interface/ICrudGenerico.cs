﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVeiculosData.Crud.Interface
{
    public interface ICrudGenerico
    {
        void Salvar<T>(T entidade) where T : class;
        void Editar<T>(T entidade, int id) where T : class;
        void Excluir<T>(int id) where T : class;
    }
}
