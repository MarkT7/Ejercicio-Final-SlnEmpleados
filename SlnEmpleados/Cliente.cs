using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public class Cliente:Persona
    {
        public string Cuit { get; set; }
        public int Telefono { get; set; }

        public Cliente(string cuit, int telefono)
        {
            Cuit = cuit;
            Telefono = telefono;
        }
    }
}
