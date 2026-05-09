namespace GBPColmadoNet.UI.Forms.Ventas
{
    partial class AperturaCajaForm
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
            lblInstruccion = new Label();
            txtMontoInicial = new TextBox();
            btnAbrirCaja = new Button();
            SuspendLayout();
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Location = new Point(26, 22);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(252, 15);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "Ingrese el monto inicial (menú) para abrir caja:";
            // 
            // txtMontoInicial
            // 
            txtMontoInicial.Location = new Point(26, 45);
            txtMontoInicial.Margin = new Padding(3, 2, 3, 2);
            txtMontoInicial.Name = "txtMontoInicial";
            txtMontoInicial.Size = new Size(219, 23);
            txtMontoInicial.TabIndex = 1;
            // 
            // btnAbrirCaja
            // 
            btnAbrirCaja.BackColor = Color.Teal;
            btnAbrirCaja.ForeColor = Color.White;
            btnAbrirCaja.Location = new Point(26, 75);
            btnAbrirCaja.Margin = new Padding(3, 2, 3, 2);
            btnAbrirCaja.Name = "btnAbrirCaja";
            btnAbrirCaja.Size = new Size(219, 30);
            btnAbrirCaja.TabIndex = 2;
            btnAbrirCaja.Text = "Abrir Caja";
            btnAbrirCaja.UseVisualStyleBackColor = false;
            btnAbrirCaja.Click += btnAbrirCaja_Click;
            // 
            // AperturaCajaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 128);
            Controls.Add(btnAbrirCaja);
            Controls.Add(txtMontoInicial);
            Controls.Add(lblInstruccion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AperturaCajaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apertura de Caja";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.Button btnAbrirCaja;
    }
}
