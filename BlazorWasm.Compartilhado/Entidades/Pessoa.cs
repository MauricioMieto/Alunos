using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorWasm.Compartilhado.Entidades
{
    public class Pessoa :IEntity
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
    }
}
