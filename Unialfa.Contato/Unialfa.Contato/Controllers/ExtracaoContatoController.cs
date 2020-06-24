using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Unialfa.Contato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtracaoContatoController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(int cpf)
        {
            return new List<Contato>
            {
                new Contato{ Cpf = "01234567800", Telefone = "6299990000" },
                new Contato{ Cpf = "01234567800", Telefone ="6299990001" },
                new Contato{ Cpf = "01234567800", Telefone ="6299990002" },
                 new Contato{ Cpf = "98745612300", Telefone ="6299990003" },
                 new Contato{ Cpf = "98745612300", Telefone ="6299990004" },
                 new Contato{ Cpf = "98745612300", Telefone ="6299990005" }
             }.Where(c => c.Cpf == cpf.ToString()).Select(c => c.Telefone).ToList();
        }
    }
}