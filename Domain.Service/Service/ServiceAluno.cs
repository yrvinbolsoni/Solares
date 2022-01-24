using Domain.Core.Interfaces.Repository;
using Domain.Core.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Service
{
    public class ServiceAluno  : ServiceBase<Aluno>, IServiceAluno
    {

        public readonly IRepositoryAluno _repositoryAluno;

        public ServiceAluno(IRepositoryAluno  RepositoryAluno)
            : base(RepositoryAluno)
        {
            _repositoryAluno = RepositoryAluno;

        }
    }
}
