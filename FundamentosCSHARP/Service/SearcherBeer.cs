using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using FundamentosCSHARP.Errors;

namespace FundamentosCSHARP.Service
{
    public class SearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza(){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
            new Cerveza(){ Alcohol=8, Cantidad=5, Nombre="Ticús", Marca="Colima"},
            new Cerveza(){ Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"}
        };

        public int GetCantidad(string Nombre)
        {
            var cerveza = (from d in cervezas
                          where d.Nombre == Nombre
                          select d).FirstOrDefault();

            if(cerveza==null)
            {
                //lanzar nueva excepcion
                throw new BeerNotFoundException("La cerveza se ha terminado");
            }

            return cerveza.Cantidad;
        }
    }
}
