using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopvelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class BakesController : Controller
    {
        public readonly Bakecontext context;

        public BakesController(Bakecontext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<IEnumerable<Bake>>>Get()
        {
            return await context.Bakes.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Bake>> Get(int id)
        {
            Bake bake = await context.Bakes.FirstOrDefaultAsync(x => x.BakeId == id);
            if(bake==null)
            {
                return NotFound();

            }
            return new ObjectResult(bake);
            //return bake;
        }
        [HttpPost]
        public async Task<ActionResult<Bake>> Post(Bake bake)
        {
            context.Bakes.Add(bake);
            await context.SaveChangesAsync();
            return Ok(bake);
        }
        [HttpPut]
        public async Task <ActionResult<Bake>> Put(Bake bake)
        {
            context.Update(bake);
            await context.SaveChangesAsync();
            return Ok(bake);
        }
        [HttpDelete("{id}")]
        public async Task <ActionResult<Bake>> Delete(int id)
        {
            Bake bake =await context.Bakes.FirstOrDefaultAsync(x => x.BakeId == id);
            if(bake==null)
            {
                return NotFound();
            }
            context.Bakes.Remove(bake);
            await context.SaveChangesAsync();
            return Ok(bake);
        }
    }
}
