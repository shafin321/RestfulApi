using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public class MockCommandRepo : ICommandRepo
    {
        

        public IEnumerable<Command> GetCommands()
        {
            List<Command> commands = new List<Command>
            { new Command { Id = 1, HowTo = "Cook salmon", Line = "Oil & Onion", Platform = "kettle & Pan" },
              new Command { Id = 2, HowTo = "Boil egg", Line = "water", Platform = "kettle & Pan" },
              new Command { Id = 3, HowTo = "Cut bread", Line = "Get knife", Platform = "knife & chopBoard" }
        };

            return commands;

            }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 1, HowTo = "Cook salmon", Line = "Oil & Onion", Platform = "kettle & Pan" };
        }

        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
