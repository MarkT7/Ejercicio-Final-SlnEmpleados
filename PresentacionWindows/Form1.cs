using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Empleado> empleados1 = new List<Empleado>();

            empleados1.Add(new Empleado("ab123", "4832481", "Juan", "Ramirez"));
            empleados1.Add(new Empleado("ab543", "39234852", "Sofia", "Cruz"));
            empleados1.Add(new Empleado("ab754", "1237583", "Elena", "Tomas"));

            Departamento DepartamentoA = new Departamento("axhets", "Almacen Hogareño", empleados1);

            myGrid.DataSource = empleados1;
        }
    }
}
