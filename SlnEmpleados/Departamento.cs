using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Empleado> Empleados { get; set; }

        public Departamento(int id, string nombre, List<Empleado> empleados)
        {
            Id = id;
            Nombre = nombre;
            Empleados = empleados;
        }
    }
}
