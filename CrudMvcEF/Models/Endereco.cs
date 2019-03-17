using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMvcEF.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string NumResidencia { get; set; }

        public Endereco()
        {

        }

        public Endereco(int id, string rua, string cidade, string uf, string numResidencia)
        {
            Id = id;
            Rua = rua;
            Cidade = cidade;
            Uf = uf;
            NumResidencia = numResidencia;
        }
    }
}
