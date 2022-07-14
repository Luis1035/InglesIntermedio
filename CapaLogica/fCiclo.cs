using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaLogica
{
    public class fCiclo
    {

        public List<Ciclo> ListarCiclo()
        {
            List<Ciclo> ciclos = null;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    ciclos = db.Ciclo.OrderBy(x=>x.IdCiclo).ToList();
                    ciclos.Insert(0, new Ciclo() { Ciclo_ = "*", IdCiclo = 0 }); // insertar un * como primer elemento.
                    

                }
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            return ciclos;
        }



        public bool AgregarCiclo(Ciclo obj)
        {
            bool proceso = false;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    db.Ciclo.Add(obj);
                    db.SaveChanges();
                    proceso = true;

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

            }

            return proceso;
        }



        public bool ActualizarCiclo(Ciclo obj)
        {
            bool proceso = false;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    proceso = true;

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

            }

            return proceso;
        }


        public bool EliminarCiclo(int idCiclo)
        {
            bool proceso = false;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    var Ciclo = db.Ciclo.Where(x => x.IdCiclo == idCiclo).Single();
                    db.Ciclo.Remove(Ciclo);
                    db.SaveChanges();
                    proceso = true;

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

            }

            return proceso;
        }


        public Ciclo BuscarCicloId(int id)
        {
            Ciclo obj = null;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    var query = db.Ciclo.Where(x => x.IdCiclo == id);
                    var Ciclo = query.First();
                    obj = (Ciclo)Ciclo;
                }

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            return obj;
        }



        public Ciclo BuscarCicloNombre(string nombre)
        {
            Ciclo obj = null;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    var query = db.Ciclo.Where(x => x.Ciclo_ == nombre);
                    var Ciclo = query.First();
                    obj = (Ciclo)Ciclo;
                }

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            return obj;
        }


    }
}
