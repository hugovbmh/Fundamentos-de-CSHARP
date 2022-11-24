using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{   //las interfaces empiezan con un "I" al inicio
    //en las interfaces se escriben las reglas
    //para que luego la clase que use dicha interfaz, esté obligada
    //a usar dichas reglas "y que pertenezca a un club"
    public interface IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado();
    }
}
