﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 3 copas");
        }
        public Vino(int Cantidad, string Nombre = "Vino")
            : base(Nombre, Cantidad) //base() hace referencia al 
                                     //contructor de la clase padre
        {

        }


    }
}
