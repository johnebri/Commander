using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        public ActionResult <IEnumerable<CommandModel>> GetAllCommands()
        {
            return 1;
        }

        public ActionResult <CommandModel> GetCommandById(int id)
        {
            return 1;
        }
    }
}