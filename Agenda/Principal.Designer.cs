namespace Agenda
{
    partial class Principal
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
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtFiltrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvAgenda = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(23, 183);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(85, 26);
            this.BtnRegistrar.TabIndex = 1;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(118, 183);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(85, 26);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(213, 183);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(85, 26);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(23, 135);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(117, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(214, 135);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(130, 20);
            this.TxtTelefono.TabIndex = 5;
            // 
            // TxtFiltrar
            // 
            this.TxtFiltrar.Location = new System.Drawing.Point(441, 224);
            this.TxtFiltrar.Name = "TxtFiltrar";
            this.TxtFiltrar.Size = new System.Drawing.Size(140, 20);
            this.TxtFiltrar.TabIndex = 6;
            this.TxtFiltrar.TextChanged += new System.EventHandler(this.TxtFiltrar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filtrar";
            // 
            // DgvAgenda
            // 
            this.DgvAgenda.AllowUserToAddRows = false;
            this.DgvAgenda.AllowUserToDeleteRows = false;
            this.DgvAgenda.AllowUserToResizeColumns = false;
            this.DgvAgenda.AllowUserToResizeRows = false;
            this.DgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAgenda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvAgenda.Location = new System.Drawing.Point(0, 250);
            this.DgvAgenda.Name = "DgvAgenda";
            this.DgvAgenda.ReadOnly = true;
            this.DgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAgenda.Size = new System.Drawing.Size(593, 266);
            this.DgvAgenda.TabIndex = 10;
            this.DgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAgenda_CellClick);
            this.DgvAgenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAgenda_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 75);
            this.label4.TabIndex = 11;
            this.label4.Text = "My Agenda";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgvAgenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFiltrar);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnRegistrar);
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvAgenda;
        private System.Windows.Forms.Label label4;
    }
}

