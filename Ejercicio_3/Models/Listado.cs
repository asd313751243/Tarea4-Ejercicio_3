using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public class Listado
    {
        private static List<Carro> carros;

        public List<Carro> Carros
        {
            get
            {
                if (carros == null)
                    carros = new List<Carro>();
                return carros;
            }
        }
    }
}
