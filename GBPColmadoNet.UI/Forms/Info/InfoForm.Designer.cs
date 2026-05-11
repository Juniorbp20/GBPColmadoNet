namespace GBPColmadoNet.UI.Forms.Ayuda
{
    partial class InfoForm
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
            lbInfoSistem = new Label();
            lbNombreSistema = new Label();
            lbCreador = new Label();
            lbProfesor = new Label();
            lbVersion = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lbInfoSistem
            // 
            lbInfoSistem.AutoSize = true;
            lbInfoSistem.BackColor = SystemColors.Control;
            lbInfoSistem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbInfoSistem.Location = new Point(60, 9);
            lbInfoSistem.Name = "lbInfoSistem";
            lbInfoSistem.Size = new Size(249, 30);
            lbInfoSistem.TabIndex = 0;
            lbInfoSistem.Text = "Informacion del sistema";
            // 
            // lbNombreSistema
            // 
            lbNombreSistema.AutoSize = true;
            lbNombreSistema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombreSistema.Location = new Point(200, 60);
            lbNombreSistema.Name = "lbNombreSistema";
            lbNombreSistema.Size = new Size(0, 21);
            lbNombreSistema.TabIndex = 1;
            // 
            // lbCreador
            // 
            lbCreador.AutoSize = true;
            lbCreador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCreador.Location = new Point(200, 100);
            lbCreador.Name = "lbCreador";
            lbCreador.Size = new Size(0, 21);
            lbCreador.TabIndex = 3;
            // 
            // lbProfesor
            // 
            lbProfesor.AutoSize = true;
            lbProfesor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProfesor.Location = new Point(200, 140);
            lbProfesor.Name = "lbProfesor";
            lbProfesor.Size = new Size(0, 21);
            lbProfesor.TabIndex = 5;
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVersion.Location = new Point(200, 180);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(0, 21);
            lbVersion.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 60);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Sistema:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 100);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 2;
            label2.Text = "Creador del Sistema:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 140);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 4;
            label3.Text = "Profesor Guia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 180);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 6;
            label4.Text = "Version:";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 239);
            Controls.Add(lbInfoSistem);
            Controls.Add(label1);
            Controls.Add(lbNombreSistema);
            Controls.Add(label2);
            Controls.Add(lbCreador);
            Controls.Add(label3);
            Controls.Add(lbProfesor);
            Controls.Add(label4);
            Controls.Add(lbVersion);
            Name = "InfoForm";
            Text = "Informacion del sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbInfoSistem;
        private Label lbNombreSistema;
        private Label lbCreador;
        private Label lbProfesor;
        private Label lbVersion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}