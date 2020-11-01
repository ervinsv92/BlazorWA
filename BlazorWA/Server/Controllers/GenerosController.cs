using BlazorWA.Shared;
using BlazorWA.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWA.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenerosController : ControllerBase
    {

        private readonly ApplicationDBContext context;

        public GenerosController(ApplicationDBContext context) {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Genero genero) {
            context.Add(genero);
            await context.SaveChangesAsync();
            return genero.Id;
        }
    }
}
