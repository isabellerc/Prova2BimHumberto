using AutoMapper;
using Revisao.Data.Providers.MongoDB.Collections;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.AutoMapper
{
    public class CollectionToDomain : Profile
    {
        public CollectionToDomain()
        {
            CreateMap<JogosCollection, RegistroJogo>()
            .ConstructUsing(X => new RegistroJogo(X.primeiroNumero, X.segundoNumero, X.terceiroNumero, X.quartoNumero, X.quintoNumero, X.sextoNumero));
        }
    }
}
