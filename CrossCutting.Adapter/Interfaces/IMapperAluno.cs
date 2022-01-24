using Domain.DTO;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Adapter.Interfaces
{
    public interface IMapperAluno
    {
        #region Mappers

        //  alunoDTO  para aluno
        Aluno MapperToEntity(AlunoDTO alunoDTO);

        // aluno para alunos DTO
        IEnumerable<AlunoDTO> MapperListAluno(IEnumerable<Aluno> alunos);

        //aluno para alunoDTO
        AlunoDTO  MapperToDTO(Aluno number);

        #endregion


    }
}
