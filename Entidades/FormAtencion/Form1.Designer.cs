namespace FormAtencion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            btnAtender = new Button();
            btnSalir = new Button();
            rtbInfoMedico = new RichTextBox();
            lblMedicos = new Label();
            lblPacientes = new Label();
            SuspendLayout();
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 72);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(343, 319);
            lstMedicos.TabIndex = 0;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(389, 72);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(360, 319);
            lstPacientes.TabIndex = 1;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(769, 12);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(132, 73);
            btnAtender.TabIndex = 2;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(769, 510);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 73);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 407);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(737, 176);
            rtbInfoMedico.TabIndex = 4;
            rtbInfoMedico.Text = "";
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(12, 29);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(52, 15);
            lblMedicos.TabIndex = 5;
            lblMedicos.Text = "Medicos";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(389, 29);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 6;
            lblPacientes.Text = "Pacientes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 606);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(rtbInfoMedico);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poropat Jeremias";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Button btnAtender;
        private Button btnSalir;
        private RichTextBox rtbInfoMedico;
        private Label lblMedicos;
        private Label lblPacientes;
    }
}