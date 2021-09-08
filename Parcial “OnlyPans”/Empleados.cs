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
	public partial class Empleados : Form
	{
		public Empleados()
		{
			InitializeComponent();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (txtcliente.Text == "" | txtcedula.Text == "") 
			{
				MessageBox.Show("Falta nombre o cedula");
				return;
			}
			if (Convert.ToInt16(contador_no_aliñado.Text) == 0 && Convert.ToInt16(contador_aliñado.Text) == 0 && Convert.ToInt16(contador_especial.Text) == 0)
			{
				MessageBox.Show("No selecciono ningun tipo de pan");
				return;
			}
			recibo.Text = recibo.Text + "Nombre: " + txtcliente.Text + "\nCedula: " + txtcedula.Text +"\nFecha de venta: " + dtfecha.Value + "\n";
			if (Convert.ToInt16(contador_no_aliñado.Text) != 0)
			{
				recibo.Text = recibo.Text + "Panes no aliñados comprados: " + contador_no_aliñado.Text +"\n";
			}
			if (Convert.ToInt16(contador_aliñado.Text) != 0)
			{
				recibo.Text = recibo.Text + "Panes aliñados comprados: " + contador_aliñado.Text + "\n";
			}
			if (Convert.ToInt16(contador_especial.Text) != 0)
			{
				recibo.Text = recibo.Text + "Panes especial comprados: " + contador_especial.Text + "\n";
			}
			recibo.Text = recibo.Text + "Total= " + Convert.ToString((Convert.ToInt16(contador_no_aliñado.Text) * 500) + (Convert.ToInt16(contador_aliñado.Text) * 1000) + (Convert.ToInt16(contador_especial.Text) * 2000) + "\n ---------------------------------------------------------------------------- \n");
			contador_no_aliñado.Text = "0";
			contador_aliñado.Text = "0";
			contador_especial.Text = "0";
			txtcliente.Text = "";
			txtcedula.Text = "";
		}

		private void boton_no_aliñado_negativo_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt16(contador_no_aliñado.Text) == 0)
			{
				return;
			}
			else 
			{
				contador_no_aliñado.Text = Convert.ToString(Convert.ToInt16(contador_no_aliñado.Text) - 1);
			}
		}

		private void boton_no_aliñado_positivo_Click(object sender, EventArgs e)
		{
			contador_no_aliñado.Text = Convert.ToString(Convert.ToInt16(contador_no_aliñado.Text) + 1);
		}

		private void boton_aliñado_negativo_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt16(contador_aliñado.Text) == 0)
			{
				return;
			}
			else
			{
				contador_aliñado.Text = Convert.ToString(Convert.ToInt16(contador_aliñado.Text) - 1);
			}
		}

		private void boton_aliñado_positivo_Click(object sender, EventArgs e)
		{
			contador_aliñado.Text = Convert.ToString(Convert.ToInt16(contador_aliñado.Text) + 1);
		}

		private void boton_especial_negativo_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt16(contador_especial.Text) == 0)
			{
				return;
			}
			else
			{
				contador_especial.Text = Convert.ToString(Convert.ToInt16(contador_especial.Text) - 1);
			}
		}

		private void boton_especial_positivo_Click(object sender, EventArgs e)
		{
			contador_especial.Text = Convert.ToString(Convert.ToInt16(contador_especial.Text) + 1);
		}

		private void Empleados_Load(object sender, EventArgs e)
		{

		}
	}
}
