using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{ 

    //clase padre o base
    class Figura
    {
       
        public virtual string dibujar()
        {
            return "La figura se a dibujado";
        }

        //Este método se debe sobreescribir
        public string dibujar(string name, string owner)
        {
            return "La figura " + name + " esta siendo dibujada por" + owner ;
        }

        public virtual string establecerColor()
        {
            return "La figura tiene color";
        }

        public string establecerColor(string color, string name)
        {
            return "Se le dio el color" + color + " a la figura " + name;
        }

        public virtual string obtenerColor()
        {
            return "Obteniendo el color de la figura";
        }
        
        public string obtenerColor(string color )
        {
            return "El color obtendio es: " + color;
        }

    }
}
