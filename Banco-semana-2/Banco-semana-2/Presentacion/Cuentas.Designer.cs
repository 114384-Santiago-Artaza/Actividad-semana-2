namespace Banco_semana_2
{
    partial class Cuentas
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
            this.CboTipo = new System.Windows.Forms.ComboBox();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.TxtUltimo = new System.Windows.Forms.TextBox();
            this.TxtCbu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DgCuentas = new System.Windows.Forms.DataGridView();
            this.ColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // CboTipo
            // 
            this.CboTipo.FormattingEnabled = true;
            this.CboTipo.Location = new System.Drawing.Point(117, 87);
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Size = new System.Drawing.Size(121, 21);
            this.CboTipo.TabIndex = 0;
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(412, 26);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(121, 21);
            this.CboCliente.TabIndex = 1;
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(117, 53);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(121, 20);
            this.TxtSaldo.TabIndex = 2;
            // 
            // TxtUltimo
            // 
            this.TxtUltimo.Location = new System.Drawing.Point(412, 57);
            this.TxtUltimo.Name = "TxtUltimo";
            this.TxtUltimo.Size = new System.Drawing.Size(134, 20);
            this.TxtUltimo.TabIndex = 4;
            // 
            // TxtCbu
            // 
            this.TxtCbu.Location = new System.Drawing.Point(117, 23);
            this.TxtCbu.Name = "TxtCbu";
            this.TxtCbu.Size = new System.Drawing.Size(121, 20);
            this.TxtCbu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cbu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ultimo Movimiento";
            // 
            // DgCuentas
            // 
            this.DgCuentas.AllowUserToAddRows = false;
            this.DgCuentas.AllowUserToDeleteRows = false;
            this.DgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCod,
            this.ColCbu,
            this.ColSaldo,
            this.ColTipo,
            this.Colcliente,
            this.Colult,
            this.ColAccion});
            this.DgCuentas.Location = new System.Drawing.Point(1, 176);
            this.DgCuentas.Name = "DgCuentas";
            this.DgCuentas.ReadOnly = true;
            this.DgCuentas.Size = new System.Drawing.Size(677, 214);
            this.DgCuentas.TabIndex = 12;
            this.DgCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColCod
            // 
            this.ColCod.HeaderText = "Column1";
            this.ColCod.Name = "ColCod";
            this.ColCod.ReadOnly = true;
            this.ColCod.Visible = false;
            // 
            // ColCbu
            // 
            this.ColCbu.HeaderText = "CBU";
            this.ColCbu.Name = "ColCbu";
            this.ColCbu.ReadOnly = true;
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.ReadOnly = true;
            // 
            // ColTipo
            // 
            this.ColTipo.HeaderText = "Tipo de cuenta";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            // 
            // Colcliente
            // 
            this.Colcliente.HeaderText = "Cliente";
            this.Colcliente.Name = "Colcliente";
            this.Colcliente.ReadOnly = true;
            this.Colcliente.Width = 130;
            // 
            // Colult
            // 
            this.Colult.HeaderText = "Ultimo Movimiento";
            this.Colult.Name = "Colult";
            this.Colult.ReadOnly = true;
            // 
            // ColAccion
            // 
            this.ColAccion.HeaderText = "Acciones";
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.ReadOnly = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(713, 136);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(588, 136);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgCuentas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCbu);
            this.Controls.Add(this.TxtUltimo);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.CboCliente);
            this.Controls.Add(this.CboTipo);
            this.Name = "Form1";
            this.Text = "Cuentas ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboTipo;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.TextBox TxtUltimo;
        private System.Windows.Forms.TextBox TxtCbu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCbu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colult;
        private System.Windows.Forms.DataGridViewButtonColumn ColAccion;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnNuevo;
    }
}

