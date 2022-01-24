using Data.DBConfiguration.EFcore;
using Domain.Core.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class RepositoryAluno : RepositoryBase<Aluno>, IRepositoryAluno
    {
        private readonly  SolaresContext _context;
        public RepositoryAluno(SolaresContext Context)
            : base(Context)
        {

        }

    }
}
