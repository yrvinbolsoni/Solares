using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;
namespace Application.Interface
{
    public interface   IApplicationServiceAluno
    {
        // camada que conversa direto com a aplicação
        void Add(AlunoDTO aluno);
        AlunoDTO GetById(int id);
        IEnumerable<AlunoDTO> GetAll();

        IEnumerable<AlunoDTO> GetAllPag(int skip = 0 , int take =25);
        void Update(AlunoDTO aluno);

        void Remove(AlunoDTO aluno);
        void Dispose();


    }
}
