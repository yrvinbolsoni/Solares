using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class AlunoDTO
    {
        [JsonIgnore]
        public int Id { get; set; }
        public String Nome { get; set; }
        public string Endereco { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatNascimento { get; set; }

    }
}
