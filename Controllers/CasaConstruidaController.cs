using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAREA.Data;
using TAREA.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TAREA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasaConstruidaController : ControllerBase
    {


        readonly Repository Repositorio;

        public CasaConstruidaController(Repository contexto) 
        {
            this.Repositorio = contexto;
        }


        [HttpGet]
        public ActionResult Index()
        {

            return Ok(Repositorio.GetCasas());

        }



        [HttpGet("{idModelo}")]
        public ActionResult Details(int idModelo)
        {

            var modelo = Repositorio.EncontrarModelo(idModelo);
            if (modelo == null)
            {
                return NotFound();
            }
            


            return Ok(Repositorio.GetCasas().Where(x=>x.IDModelo==idModelo));

        }


        [HttpPost]
        public ActionResult Create(CasaConstruida casa)
        {
            var modelo = Repositorio.EncontrarModelo(casa.IDModelo);
            if (modelo == null) return NotFound();

            


            Repositorio.AddCasaConstruida(casa);

            return Created(nameof(Index), casa);
        }

        [HttpPut("{id}")]
        public ActionResult Edit(int id, CasaConstruida casa)
        {
            var modelo = Repositorio.EncontrarModelo(id);

            if (modelo == null) return NotFound();

            if (modelo.Id != casa.IDModelo)
            {
                return BadRequest();
            }


            Repositorio.ActualizarCasa(casa);


            return Ok(casa);

        }




        /*
         // GET: api/<CasaConstruidaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CasaConstruidaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CasaConstruidaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CasaConstruidaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CasaConstruidaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
         */
    }
}
