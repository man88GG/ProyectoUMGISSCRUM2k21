﻿
namespace CapaVista.Mantenimientos
{
    partial class frmPais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPais));
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvPais = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.rbDeshabilitado = new System.Windows.Forms.RadioButton();
            this.rbHabilitado = new System.Windows.Forms.RadioButton();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(187, 330);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(132, 27);
            this.txtEstado.TabIndex = 53;
            this.txtEstado.Tag = "estadoPais";
            // 
            // dgvPais
            // 
            this.dgvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPais.Location = new System.Drawing.Point(470, 180);
            this.dgvPais.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPais.Name = "dgvPais";
            this.dgvPais.RowHeadersWidth = 51;
            this.dgvPais.Size = new System.Drawing.Size(976, 292);
            this.dgvPais.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Estado";
            // 
            // rbDeshabilitado
            // 
            this.rbDeshabilitado.AutoSize = true;
            this.rbDeshabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbDeshabilitado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeshabilitado.ForeColor = System.Drawing.Color.White;
            this.rbDeshabilitado.Location = new System.Drawing.Point(52, 417);
            this.rbDeshabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rbDeshabilitado.Name = "rbDeshabilitado";
            this.rbDeshabilitado.Size = new System.Drawing.Size(138, 24);
            this.rbDeshabilitado.TabIndex = 49;
            this.rbDeshabilitado.TabStop = true;
            this.rbDeshabilitado.Text = "Deshabilitado";
            this.rbDeshabilitado.UseVisualStyleBackColor = false;
            // 
            // rbHabilitado
            // 
            this.rbHabilitado.AutoSize = true;
            this.rbHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbHabilitado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHabilitado.ForeColor = System.Drawing.Color.White;
            this.rbHabilitado.Location = new System.Drawing.Point(52, 385);
            this.rbHabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rbHabilitado.Name = "rbHabilitado";
            this.rbHabilitado.Size = new System.Drawing.Size(110, 24);
            this.rbHabilitado.TabIndex = 48;
            this.rbHabilitado.TabStop = true;
            this.rbHabilitado.Text = "Habilitado";
            this.rbHabilitado.UseVisualStyleBackColor = false;
            // 
            // txtCapital
            // 
            this.txtCapital.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapital.Location = new System.Drawing.Point(186, 280);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(132, 27);
            this.txtCapital.TabIndex = 45;
            this.txtCapital.Tag = "capitalPais";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(186, 237);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 27);
            this.txtNombre.TabIndex = 44;
            this.txtNombre.Tag = "nombrePais";
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(186, 195);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(132, 27);
            this.txtPais.TabIndex = 43;
            this.txtPais.Tag = "pkIdPais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Capital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(48, 194);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(62, 20);
            this.lblId.TabIndex = 38;
            this.lblId.Text = "ID Pais";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(14, 14);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 55;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // frmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1497, 503);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dgvPais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbDeshabilitado);
            this.Controls.Add(this.rbHabilitado);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.Name = "frmPais";
            this.Text = "frmPais";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dgvPais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbDeshabilitado;
        private System.Windows.Forms.RadioButton rbHabilitado;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private CapaVistaNavegador.Navegador navegador1;
    }
}