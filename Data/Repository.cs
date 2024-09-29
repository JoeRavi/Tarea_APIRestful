using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAREA.Models;

namespace TAREA.Data
{
    public class Repository
    {
        readonly ApplicationDataBaseContext db;



        public Repository(ApplicationDataBaseContext db) 
        {
            this.db = db;
        
        }



        public IEnumerable<ModeloCasa> GetAll() 
        {

            return db.ModelosDeCasas.ToList();
        
        }

        public IEnumerable<CasaConstruida> GetCasas()
        {

            return db.CasasConstruidas.ToList();

        }

        public void AddModeloCasa(ModeloCasa modeloCasa)
        {
            db.ModelosDeCasas.Add(modeloCasa);
            db.SaveChanges();
        }

        public void AddCasaConstruida(CasaConstruida casa)
        {
            db.CasasConstruidas.Add(casa);
            db.SaveChanges();
        }

        public CasaConstruida EncontrarCasa(int id)
        {
            return db.CasasConstruidas.Find(id);
        }





        public ModeloCasa EncontrarModelo(int id)
        {
           return  db.ModelosDeCasas.Find(id);
        }





        public void Actualizar(ModeloCasa modelo)
        {
            db.ModelosDeCasas.Update(modelo);
            db.SaveChanges();

        }

        public void ActualizarCasa(CasaConstruida casa)
        {
            db.CasasConstruidas.Update(casa);
            db.SaveChanges();

        }

        public void Delete(int id)
        {

            var modelo = EncontrarModelo(id);
            db.Remove(modelo);
            db.SaveChanges();


        }
    }
}
