using Application.Interface;
using CrossCutting.Adapter.Interfaces;
using Domain.Core.Interfaces.Service;
using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ApplicationServiceAluno : IApplicationServiceAluno
    {

        private readonly IServiceAluno _serviceAluno;
        private readonly IMapperAluno _mapperAluno;

        public ApplicationServiceAluno(IServiceAluno ServiceAluno, IMapperAluno MapperAluno)
        {
            _serviceAluno = ServiceAluno;
            _mapperAluno = MapperAluno;
        }

        public void Add(AlunoDTO aluno)
        {
            var Number = _mapperAluno.MapperToEntity(aluno);
            _serviceAluno.Add(Number);
        }

        public IEnumerable<AlunoDTO> GetAll()
        {
            var Aluno = _serviceAluno.GetAll();
            return _mapperAluno.MapperListAluno(Aluno);
        }

        public AlunoDTO GetById(int id)
        {
            var aluno = _serviceAluno.GetById(id);
            if (aluno != null)
                return _mapperAluno.MapperToDTO(aluno);

            return new AlunoDTO();
        }

        public void Remove(AlunoDTO alunoDto)
        {
            var aluno = _mapperAluno.MapperToEntity(alunoDto);
            _serviceAluno.Remove(aluno);
        }

        public void Update(AlunoDTO alunoDto)
        {
            var aluno = _mapperAluno.MapperToEntity(alunoDto);
            _serviceAluno.Update(aluno);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AlunoDTO> GetAllPag(int skip = 0, int take = 25)
        {
            var Aluno = _serviceAluno.GetAllPag(skip,take);
            return _mapperAluno.MapperListAluno(Aluno);
        }
    }
}
