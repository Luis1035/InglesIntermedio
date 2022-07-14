using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class fPalabra
    {

        public IEnumerable<dynamic> ListarPalabra(int IdCiclo, int IdCapitulo)
        {
            if (IdCiclo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra, //0
                                         Palabra = p.Palabra_.ToUpper(), //1
                                         Traduccion = p.Traduccion.ToUpper(), //2
                                         Observacion = p.Observacion.ToUpper(), //3
                                         IdCapitulo = c.IdCapitulo, //4
                                         Capitulo = c.Capitulo_.ToUpper(), //5
                                         IdCiclo = ci.IdCiclo, //6
                                         Ciclo = ci.Ciclo_.ToUpper() //7
                                     }

                                     ).ToList();

                        return query;







                        //select p.IdPalabra,p.Palabra_,p.Traduccion,c.IdCapitulo,c.Capitulo_,ci.IdCiclo,ci.Ciclo_ from palabra p inner join Capitulo c on p.IdCapitulo = c.IdCapitulo inner join Ciclo ci on c.IdCiclo = ci.IdCiclo

                    }
                }
                catch (Exception ex)
                {

                    Console.Write(ex.Message);
                    return null;
                }
            }

            else if (IdCiclo !=0 & IdCapitulo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where c.IdCiclo == IdCiclo
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_.ToUpper(),
                                         Traduccion = p.Traduccion.ToUpper(),
                                         Observacion = p.Observacion.ToUpper(),
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_.ToUpper(),
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_.ToUpper()
                                         
                                     }

                                     ).ToList();

                        return query;







                        //select p.IdPalabra,p.Palabra_,p.Traduccion,c.IdCapitulo,c.Capitulo_,ci.IdCiclo,ci.Ciclo_ from palabra p inner join Capitulo c on p.IdCapitulo = c.IdCapitulo inner join Ciclo ci on c.IdCiclo = ci.IdCiclo

                    }
                }
                catch (Exception ex)
                {

                    Console.Write(ex.Message);
                    return null;
                }

            }

            else if (IdCiclo != 0 & IdCapitulo != 0)
            {
                {
                    try
                    {
                        using (var db = new dbIntermedioEntities())
                        {

                            var query = (from p in db.Palabra
                                         join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                         join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                         where ci.IdCiclo == IdCiclo & c.IdCapitulo == IdCapitulo
                                         orderby p.IdPalabra ascending
                                         select new
                                         {
                                             IdPalabra = p.IdPalabra,
                                             Palabra = p.Palabra_.ToUpper(),
                                             Traduccion = p.Traduccion.ToUpper(),
                                             Observacion = p.Observacion.ToUpper(),
                                             IdCapitulo = c.IdCapitulo,
                                             Capitulo = c.Capitulo_.ToUpper(),
                                             IdCiclo = ci.IdCiclo,
                                             Ciclo = ci.Ciclo_.ToUpper()
                                         }

                                         ).ToList();

                            return query;







                            //select p.IdPalabra,p.Palabra_,p.Traduccion,c.IdCapitulo,c.Capitulo_,ci.IdCiclo,ci.Ciclo_ from palabra p inner join Capitulo c on p.IdCapitulo = c.IdCapitulo inner join Ciclo ci on c.IdCiclo = ci.IdCiclo

                        }
                    }
                    catch (Exception ex)
                    {

                        Console.Write(ex.Message);
                        return null;
                    }
                }
            }


            else
            {
                return null;
            }
           
        }



       




        public bool AgregarPalabra(Palabra obj)
        {
            bool proceso = false;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    db.Palabra.Add(obj);
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



        public bool ActualizarPalabra(Palabra obj)
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


        public bool EliminarPalabra(int idPalabra)
        {
            bool proceso = false;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    var Palabra = db.Palabra.Where(x => x.IdPalabra == idPalabra).Single();
                    db.Palabra.Remove(Palabra);
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


        public Palabra BuscarPalabraId(int id)
        {
            Palabra obj = null;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    var query = db.Palabra.Where(x => x.IdPalabra == id);
                    var Palabra = query.First();
                    obj = (Palabra)Palabra;
                }

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            return obj;
        }



        public Palabra BuscarPalabraNombre(string nombre)
        {
            Palabra obj = null;
            try
            {
                using (dbIntermedioEntities db = new dbIntermedioEntities())
                {
                    var query = db.Palabra.Where(x => x.Palabra_ == nombre);
                    var Palabra = query.First();
                    obj = (Palabra)Palabra;
                }

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            return obj;
        }





        public IEnumerable<dynamic> FiltrarPalabra(string Filtro, int IdCiclo, int IdCapitulo)
        {
            if (IdCiclo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where  p.Palabra_.StartsWith(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

                        return query;

                    }
                }
                catch (Exception ex)
                {

                    Console.Write(ex.Message);
                    return null;
                }
            }

            if (IdCiclo != 0 && IdCapitulo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where ci.IdCiclo == IdCiclo & p.Palabra_.StartsWith(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

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

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where ci.IdCiclo == IdCiclo & c.IdCapitulo == IdCapitulo & p.Palabra_.StartsWith(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

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


        public IEnumerable<dynamic> FiltrarPalabra2(string Filtro, int IdCiclo, int IdCapitulo)
        {
            if (IdCiclo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where p.Palabra_.Contains(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

                        return query;

                    }
                }
                catch (Exception ex)
                {

                    Console.Write(ex.Message);
                    return null;
                }
            }

            if (IdCiclo != 0 && IdCapitulo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where ci.IdCiclo == IdCiclo & p.Palabra_.Contains(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

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

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where ci.IdCiclo == IdCiclo & c.IdCapitulo == IdCapitulo & p.Palabra_.Contains(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

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


        public IEnumerable<dynamic> FiltrarObservacion(string Filtro, int IdCiclo, int IdCapitulo)
        {
            if (IdCiclo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where p.Observacion.StartsWith(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

                        return query;

                    }
                }
                catch (Exception ex)
                {

                    Console.Write(ex.Message);
                    return null;
                }
            }

            if (IdCiclo != 0 && IdCapitulo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where ci.IdCiclo == IdCiclo & p.Observacion.StartsWith(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

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

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where ci.IdCiclo == IdCiclo & c.IdCapitulo == IdCapitulo & p.Observacion.StartsWith(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

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

        public IEnumerable<dynamic> FiltrarObservacion2(string Filtro, int IdCiclo, int IdCapitulo)
        {
            if (IdCiclo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where p.Observacion.Contains(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

                        return query;

                    }
                }
                catch (Exception ex)
                {

                    Console.Write(ex.Message);
                    return null;
                }
            }

            if (IdCiclo != 0 && IdCapitulo == 0)
            {
                try
                {
                    using (var db = new dbIntermedioEntities())
                    {

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where ci.IdCiclo == IdCiclo & p.Observacion.Contains(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

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

                        var query = (from p in db.Palabra
                                     join c in db.Capitulo on p.IdCapitulo equals c.IdCapitulo
                                     join ci in db.Ciclo on c.IdCiclo equals ci.IdCiclo
                                     where ci.IdCiclo == IdCiclo & c.IdCapitulo == IdCapitulo & p.Observacion.Contains(Filtro)
                                     orderby p.IdPalabra ascending
                                     select new
                                     {
                                         IdPalabra = p.IdPalabra,
                                         Palabra = p.Palabra_,
                                         Traduccion = p.Traduccion,
                                         Observacion = p.Observacion,
                                         IdCapitulo = c.IdCapitulo,
                                         Capitulo = c.Capitulo_,
                                         IdCiclo = ci.IdCiclo,
                                         Ciclo = ci.Ciclo_
                                     }

                                     ).ToList();

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



    }

}
