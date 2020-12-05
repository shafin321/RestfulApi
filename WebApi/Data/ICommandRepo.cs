using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
   public interface ICommandRepo
    {
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);
        bool SaveChanges();

    }
}
