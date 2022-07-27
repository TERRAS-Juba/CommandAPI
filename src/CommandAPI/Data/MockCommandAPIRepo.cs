using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        List<Command> commands = new List<Command>();
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            commands.Add(new Command
            {
                Id = 0,
                HowTo = "How to generate a migration",
                CommandLine = "dotnet ef migrations add <Name of Migration>",
                Platform = ".Net Core EF"
            });
            commands.Add(new Command
            {
                Id = 1,
                HowTo = "Run Migrations",
                CommandLine = "dotnet ef database update",
                Platform = ".Net Core EF"
            });
            commands.Add(new Command
            {
                Id = 2,
                HowTo = "List active migrations",
                CommandLine = "dotnet ef migrations list",
                Platform = ".Net Core EF"
            });
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            commands.Add(new Command
            {
                Id = 0,
                HowTo = "How to generate a migration",
                CommandLine = "dotnet ef migrations add <Name of Migration>",
                Platform = ".Net Core EF"
            });
            commands.Add(new Command
            {
                Id = 1,
                HowTo = "Run Migrations",
                CommandLine = "dotnet ef database update",
                Platform = ".Net Core EF"
            });
            commands.Add(new Command
            {
                Id = 2,
                HowTo = "List active migrations",
                CommandLine = "dotnet ef migrations list",
                Platform = ".Net Core EF"
            });
            if(commands.Count==0){
                return null;
            }
            try
            {
               return commands[Id]; 
            }
            catch (System.Exception)
            {
                
                return null;
            }
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }

}