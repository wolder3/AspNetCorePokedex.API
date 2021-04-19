using AspNetCorePokedex.Application.DTO;
using AspNetCorePokedex.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCorePokedex.Api.Mapping
{
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<Pokemon, PokemonDTO>();
            CreateMap<Move, MoveDTO>();
            CreateMap<Domain.Entities.Type, TypeDTO>();
            CreateMap<Base, BaseDTO>();
        }
    }
}
