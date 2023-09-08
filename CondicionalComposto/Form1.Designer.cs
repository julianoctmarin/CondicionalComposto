namespace CondicionalComposto
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
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            lblNota4 = new Label();
            lblMed = new Label();
            lblMedia = new Label();
            lblSit = new Label();
            btnCalcular = new Button();
            lblSituacao = new Label();
            txtNota4 = new TextBox();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(41, 43);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(42, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(41, 77);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(42, 15);
            lblNota2.TabIndex = 1;
            lblNota2.Text = "Nota 2";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(41, 110);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(42, 15);
            lblNota3.TabIndex = 2;
            lblNota3.Text = "Nota 3";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(212, 35);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 3;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(212, 69);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 4;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(212, 102);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 5;
            // 
            // lblNota4
            // 
            lblNota4.AutoSize = true;
            lblNota4.Location = new Point(41, 139);
            lblNota4.Name = "lblNota4";
            lblNota4.Size = new Size(42, 15);
            lblNota4.TabIndex = 6;
            lblNota4.Text = "Nota 4";
            // 
            // lblMed
            // 
            lblMed.AutoSize = true;
            lblMed.Location = new Point(41, 216);
            lblMed.Name = "lblMed";
            lblMed.Size = new Size(40, 15);
            lblMed.TabIndex = 7;
            lblMed.Text = "Média";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(124, 216);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(0, 15);
            lblMedia.TabIndex = 8;
            // 
            // lblSit
            // 
            lblSit.AutoSize = true;
            lblSit.Location = new Point(41, 266);
            lblSit.Name = "lblSit";
            lblSit.Size = new Size(52, 15);
            lblSit.TabIndex = 9;
            lblSit.Text = "Situação";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(139, 333);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(124, 266);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(0, 15);
            lblSituacao.TabIndex = 11;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(212, 136);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(100, 23);
            txtNota4.TabIndex = 12;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(139, 386);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 432);
            Controls.Add(btnLimpar);
            Controls.Add(txtNota4);
            Controls.Add(lblSituacao);
            Controls.Add(btnCalcular);
            Controls.Add(lblSit);
            Controls.Add(lblMedia);
            Controls.Add(lblMed);
            Controls.Add(lblNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Name = "Form1";
            Text = "Média Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Label lblNota4;
        private Label lblMed;
        private Label lblMedia;
        private Label lblSit;
        private Button btnCalcular;
        private Label lblSituacao;
        private TextBox txtNota4;
        private Button btnLimpar;
    }
}