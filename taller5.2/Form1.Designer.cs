﻿namespace taller5._2
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnir = new System.Windows.Forms.Button();
            this.lbxnumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de números a mostrar:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(322, 43);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(44, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // btnir
            // 
            this.btnir.Location = new System.Drawing.Point(401, 42);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(32, 23);
            this.btnir.TabIndex = 2;
            this.btnir.Text = "Ir";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.btnir_Click);
            // 
            // lbxnumeros
            // 
            this.lbxnumeros.FormattingEnabled = true;
            this.lbxnumeros.Location = new System.Drawing.Point(211, 74);
            this.lbxnumeros.Name = "lbxnumeros";
            this.lbxnumeros.Size = new System.Drawing.Size(68, 238);
            this.lbxnumeros.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 334);
            this.Controls.Add(this.lbxnumeros);
            this.Controls.Add(this.btnir);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnir;
        private System.Windows.Forms.ListBox lbxnumeros;
    }
}

