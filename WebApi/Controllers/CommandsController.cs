using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Dtos;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandRepo _repository;
        private readonly IMapper _mapper;
        public CommandsController(ICommandRepo repo,IMapper mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }

      //  private readonly MockCommandRepo _repository = new MockCommandRepo();
        // GET: api/<CommandsController>
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommand()
        {
            var commandItems = _repository.GetCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }

        // GET api/Commands/5
        [HttpGet("{id}",Name = "GetById")]
        public ActionResult <CommandReadDto> GetById(int id)
        {
            var commnad = _repository.GetCommandById(id);

            
            if(commnad != null)
            {  //mapping Command to CommandReadDto Using AutoMapper
                //its mapping commandreadDto to From command
                return Ok(_mapper.Map<CommandReadDto>(commnad));
            }

            return NotFound();
            
        }

        //Return CommandReadDto  
        // POST api/<CommandsController>
        //POST api/Commands
        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CreateCommandDto createCommandDto)
        {
            //mapping CreateCommnad to Command resource ....Map-> createCommandDto to Command
            var commnad = _mapper.Map<Command>(createCommandDto);
            _repository.CreateCommand(commnad);
            _repository.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commnad);

            //getting a single resource location -getbyId and creatng anonymous object ->new{id=commandReadDto.Id} and passing dto object
           return CreatedAtRoute(nameof(GetById), new { id = commandReadDto.Id }, commandReadDto);

          //  return Ok(commandReadDto);
        }

        // PUT api/<CommandsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommandsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
