﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMvcEF.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public Cliente()
        {

        }

        public Cliente(int id, string nome, string cpf, string rg)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
        }
    }
}
