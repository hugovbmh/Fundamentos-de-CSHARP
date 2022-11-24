using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    //heredar de Bebida (clase padre)
    public class Cerveza : Bebida, IBebidaAlcoholica, IRequestable
    {
        public int id { get; set; }
        public int Alcohol { get; set; }
        public string Marca { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 10 botellas");
        }
        public Cerveza() : base(null, 0) { }
        public Cerveza(int Cantidad, string Nombre="Cerveza") 
            :base(Nombre, Cantidad) //base() hace referencia al 
            //contructor de la clase padre
        {
            
        }

        
    }
}
