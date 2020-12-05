using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Profiles
{
    public class CommandsProfile: Profile
    {
        public CommandsProfile()
        {
            //Source->targer Mapper -->Command to CommandReadDto
            CreateMap<Command, CommandReadDto>();
            CreateMap<CreateCommandDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }

    }
}
