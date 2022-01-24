using Application.Interface;
using Application.Service;
using Autofac;
using CrossCutting.Adapter.Interfaces;
using CrossCutting.Adapter.Map;
using Domain.Core.Interfaces.Repository;
using Domain.Core.Interfaces.Service;
using Domain.Service.Service;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.IOC.Configuration
{
    public class IOC
    {

        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC


            #region IOC Application
             builder.RegisterType<ApplicationServiceAluno>().As<IApplicationServiceAluno>();


            #endregion

            #region IOC Services


            builder.RegisterType<ServiceAluno>().As<IServiceAluno>();


            #endregion

            #region IOC Repositorys SQL


            builder.RegisterType<RepositoryAluno>().As<IRepositoryAluno>();


            #endregion

            #region IOC Mapper


            builder.RegisterType<MapperAluno>().As<IMapperAluno>();


            #endregion

            #endregion
        }


    }
}
