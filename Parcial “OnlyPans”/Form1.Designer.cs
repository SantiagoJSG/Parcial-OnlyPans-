﻿
namespace Parcial__OnlyPans_
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.txtcontraseña = new System.Windows.Forms.TextBox();
			this.botonlogin = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Oswald Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(226, 166);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 35);
			this.label1.TabIndex = 2;
			this.label1.Text = "Usuario:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Oswald Medium", 15F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(197, 223);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 35);
			this.label2.TabIndex = 10;
			this.label2.Text = "Contraseña:";
			// 
			// txtusuario
			// 
			this.txtusuario.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtusuario.Location = new System.Drawing.Point(322, 166);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(243, 31);
			this.txtusuario.TabIndex = 11;
			// 
			// txtcontraseña
			// 
			this.txtcontraseña.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcontraseña.Location = new System.Drawing.Point(322, 227);
			this.txtcontraseña.Name = "txtcontraseña";
			this.txtcontraseña.Size = new System.Drawing.Size(243, 31);
			this.txtcontraseña.TabIndex = 12;
			// 
			// botonlogin
			// 
			this.botonlogin.BackColor = System.Drawing.Color.White;
			this.botonlogin.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonlogin.Location = new System.Drawing.Point(311, 281);
			this.botonlogin.Name = "botonlogin";
			this.botonlogin.Size = new System.Drawing.Size(104, 34);
			this.botonlogin.TabIndex = 13;
			this.botonlogin.Text = "Iniciar Sesión";
			this.botonlogin.UseVisualStyleBackColor = false;
			this.botonlogin.Click += new System.EventHandler(this.botonlogin_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cinzel", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(262, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(202, 44);
			this.label3.TabIndex = 14;
			this.label3.Text = "Only Pans";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.botonlogin);
			this.Controls.Add(this.txtcontraseña);
			this.Controls.Add(this.txtusuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "LogIn";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtusuario;
		private System.Windows.Forms.TextBox txtcontraseña;
		private System.Windows.Forms.Button botonlogin;
		private System.Windows.Forms.Label label3;
	}
}

