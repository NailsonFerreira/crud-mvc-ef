using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMvcEF.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        
        public Contato()
        {

        }

        public Contato(int id, string telefone, string email)
        {
            Id = id;
            Telefone = telefone;
            Email = email;
        }
    }
}
