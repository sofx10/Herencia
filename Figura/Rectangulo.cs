using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Rectangulo:Figura
    {
        //Método sobreescrito
        public override string dibujar()
        {
            return "La figura se a dibujado";
        }

        public override string establecerColor()
        {
            return "La figura tiene color";
        }

        public override string obtenerColor()
        {
            return "Obteniedo el color de la figura";
        }
    }
}
