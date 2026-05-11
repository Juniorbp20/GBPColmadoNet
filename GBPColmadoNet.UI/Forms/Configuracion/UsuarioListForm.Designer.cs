namespace GBPColmadoNet.UI.Forms.Configuracion
{
    partial class UsuarioListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblTitulo = new Label();
            panelCentral = new Panel();
            dgvUsuarios = new DataGridView();
            panelBotones = new Panel();
            btnVolver = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            panelTop.SuspendLayout();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Teal;
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.ForeColor = Color.White;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(784, 60);
            panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Transparent;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(219, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Usuarios";
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(dgvUsuarios);
            panelCentral.Controls.Add(panelBotones);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 60);
            panelCentral.Name = "panelCentral";
            panelCentral.Padding = new Padding(20);
            panelCentral.Size = new Size(784, 401);
            panelCentral.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(20, 20);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(744, 301);
            dgvUsuarios.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = SystemColors.Control;
            panelBotones.Controls.Add(btnVolver);
            panelBotones.Controls.Add(btnActualizar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Controls.Add(btnModificar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(20, 321);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(744, 60);
            panelBotones.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Silver;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.System;
            btnVolver.ForeColor = Color.Black;
            btnVolver.Location = new Point(630, 15);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 35);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Teal;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.System;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(233, 15);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 35);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Refrescar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(123, 15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.System;
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(13, 15);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 35);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // UsuarioListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panelCentral);
            Controls.Add(panelTop);
            Name = "UsuarioListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Usuarios";
            Load += UsuarioListForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVolver;
    }
}
