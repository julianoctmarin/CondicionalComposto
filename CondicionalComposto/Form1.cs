using System.Drawing;

namespace CondicionalComposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, media;

            nota1 = double.Parse(txtNota1.Text);
            nota2 = double.Parse(txtNota2.Text);
            nota3 = double.Parse(txtNota3.Text);
            nota4 = double.Parse(txtNota4.Text);
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            lblMedia.Text = media.ToString();

            if (media >= 6.0 && media <= 10.0)
            {
                lblSituacao.Text = "Aprovado(a)!";
                lblSituacao.ForeColor = Color.Green;
            }
            else if (media >= 4.0 && media <= 5.9)
            {
                lblSituacao.Text = "Exame!";
                lblSituacao.ForeColor = Color.Orange;
            }
            else if (media >= 0 && media <= 3.9)
            {
                lblSituacao.Text = "Reprovado(a)!";
                lblSituacao.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Notas digitadas inválidas");
                lblSituacao.Text = "Notas Inválidas";
                lblSituacao.ForeColor = Color.Purple;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            lblMedia.Text = "";
            lblSituacao.Text = "";
        }
    }
}