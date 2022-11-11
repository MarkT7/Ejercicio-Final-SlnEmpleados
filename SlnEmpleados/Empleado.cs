using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public class Empleado:Persona
    {
        public string Legajo { get; set; }

        public Empleado(string legajo)
        {
            Legajo = legajo;
        }
    }
}
