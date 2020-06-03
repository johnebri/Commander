using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{id=0,HowTo="CreateFile",Line="createFile",Platform="Mac"},
                new Command{id=1,HowTo="EditFile",Line="editFile",Platform="Windows"},
                new Command{id=2,HowTo="DeleteFile",Line="delFile",Platform="Linux"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{
                id=0, 
                HowTo="Create a File", 
                Line="CreateFile", 
                Platform="Windows"
            };
        }
    }
}
        