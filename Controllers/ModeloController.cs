using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TAREA.Data;
using TAREA.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TAREA.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase
    {
        readonly Repository Repository;



        public ModeloController(Repository contexto) 
        {
            this.Repository = contexto;
        
        }

       

        [HttpGet]
        public ActionResult Index() 
        {

            return Ok(Repository.GetAll());
            
        }

        [HttpPost]
        public ActionResult Create(ModeloCasa modelo) 
        {

            Repository.AddModeloCasa(modelo);
            return Created(nameof(Index),modelo);
        }



        [HttpGet("{id}")]
        public ActionResult Details(int id) 
        {

            var modelo = Repository.EncontrarModelo(id);
            if (modelo==null)
            {
                return NotFound();
            }
            return Ok(modelo);
        
        }

        [HttpPut("{id}")]
        public ActionResult Edit(int id, ModeloCasa modelo)
        {
            if (id!=modelo.Id)
            {
                return BadRequest();
            }


            Repository.Actualizar(modelo);


            return Ok(modelo);
        
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Repository.Delete(id);
            return Ok();


        }



     




    }
}
