using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness.Entidades
{
    public class Observacao
    {
        public Observacao() { }

        public Observacao(string titulo, string? descricao, DateTime dataHora)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Descricao = descricao;
            DataHora = dataHora;
        }

        public Observacao(Guid id, string titulo, string? descricao, DateTime dataHora)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataHora = dataHora;
        }

        [Required]
        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }

        [Required]
        public string? Titulo { get; set; }

        public string? Descricao { get; set; } = string.Empty;

        [Required]
        public DateTime DataHora { get; set; }
    }
}
