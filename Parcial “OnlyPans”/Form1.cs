using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial__OnlyPans_
{
	public partial class Form1 : Form
	{
		Form admin = new Admin();
		Form empleado = new Empleados();

		public Form1()
		{
			InitializeComponent();
		}
		private void botonlogin_Click(object sender, EventArgs e)
		{
			if (txtusuario.Text == "admin" && txtcontraseña.Text == "1") 
			{
				admin.Show();			
			}
			if (txtusuario.Text == "empleado" && txtcontraseña.Text == "2")
			{
				empleado.Show();
			}
		}
	}
}
