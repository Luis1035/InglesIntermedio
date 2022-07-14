using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class fCapitulo
    {

        public List<Capitulo> ListarCapitulo()
        {
            List<Capitulo> Capitulos = null;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    Capitulos = db.Capitulo.ToList();
                    Capitulos.Insert(0, new Capitulo() { Capitulo_ = "*", IdCapitulo = 0 }); // insertar un * como primer elemento.

                }
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            return Capitulos;

        }


        //--------------------------------------------------------------------------------------

        public IEnumerable<dynamic> ListarCapituloCiclo(int IdCiclo)
        {
            if (IdCiclo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from c in db.Capitulo
                                     join ci in db.Ciclo
                                     on c.IdCiclo equals ci.IdCiclo
                                     orderby c.IdCapitulo ascending
                                     select new
                                     {
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                     }).ToList();

                        return query;

                    }
                }
                catch (Exception ex)
                {

                    Console.Write(ex.Message);
                    return null;
                }

            }

            else
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from c in db.Capitulo
                                     join ci in db.Ciclo
                                     on c.IdCiclo equals ci.IdCiclo
                                     where ci.IdCiclo == IdCiclo
                                     orderby c.IdCapitulo ascending
                                     select new
                                     {
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                     }).ToList();

                        return query;

                    }
                }
                catch (Exception ex)
                {

                    Console.Write(ex.Message);
                    return null;
                }
            }
          
               

        }



//---------------------------------------------------------------
























        public List<Capitulo> ListarCapituloIdCiclo(int idCiclo)
        {
            List<Capitulo> Capitulos = null;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    Capitulos = db.Capitulo.Where(x=>x.IdCiclo== idCiclo).ToList();
                    Capitulos.Insert(0, new Capitulo() { Capitulo_ = "*", IdCapitulo = 0 }); // insertar un * como primer elemento.
                }
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            return Capitulos;

        }



        public bool AgregarCapitulo(Capitulo obj)
        {
            bool proceso = false;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    db.Capitulo.Add(obj);
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



        public bool ActualizarCapitulo(Capitulo obj)
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


        public bool EliminarCapitulo(int idCapitulo)
        {
            bool proceso = false;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    var Capitulo = db.Capitulo.Where(x => x.IdCapitulo == idCapitulo).Single();
                    db.Capitulo.Remove(Capitulo);
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


        public Capitulo BuscarCapituloId(int id)
        {
            Capitulo obj = null;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    var query = db.Capitulo.Where(x => x.IdCapitulo == id);
                    var Capitulo = query.First();
                    obj = (Capitulo)Capitulo;
                }

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            return obj;
        }



     


        public Capitulo BuscarCapituloNombre(string nombre)
        {
            Capitulo obj = null;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    var query = db.Capitulo.Where(x => x.Capitulo_ == nombre);
                    var Capitulo = query.First();
                    obj = (Capitulo)Capitulo;
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
