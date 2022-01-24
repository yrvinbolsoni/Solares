using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Aluno : Base
    {
        [Column("Nome", Order = 2, TypeName = "Varchar(256)")]
        public String Nome { get; set; }

        [Column("Endereco", Order = 3, TypeName = "Varchar(256)")]
        public string Endereco { get; set; }

        [Column("DatNascimento", Order = 4, TypeName = "Date")]
        public DateTime DatNascimento { get; set; }

        [Column("DataAtualizacao", Order = 5, TypeName = "Date")]
        public DateTime DataAtualizacao { get; set; }

        [Column("DataCriacao", Order = 6, TypeName = "Date")]
        public DateTime DataCriacao { get; set; }


    }
}
