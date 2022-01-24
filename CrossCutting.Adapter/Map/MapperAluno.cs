using CrossCutting.Adapter.Interfaces;
using Domain.DTO;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Adapter.Map
{
    public class MapperAluno : IMapperAluno
    {

        //prop
        List<AlunoDTO> AlunoDTOS = new List<AlunoDTO>();

        public IEnumerable<AlunoDTO> MapperListAluno(IEnumerable<Aluno> alunos)
        {
            foreach (var item in alunos)
            {
                AlunoDTO aluno = new AlunoDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Endereco = item.Endereco,
                    DatNascimento = item.DatNascimento

                };
                AlunoDTOS.Add(aluno);

            }
            return AlunoDTOS;
        }

        public AlunoDTO MapperToDTO(Aluno number)
        {

            AlunoDTO aluno = new AlunoDTO
            {
                Id = number.Id,
                Nome = number.Nome,
                Endereco = number.Endereco,
                DatNascimento   = number.DatNascimento,


            };

            return aluno;

        }

        public Aluno MapperToEntity(AlunoDTO alunoDTO)
        {
            Aluno aluno = new Aluno
            {
                Id = alunoDTO.Id,
                Nome = alunoDTO.Nome,
                Endereco = alunoDTO.Endereco,
                DatNascimento = alunoDTO.DatNascimento,

            };
            return aluno;
        }
    }
}
