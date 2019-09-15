using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(txtn1.Text);
            float n2 = float.Parse(txtn2.Text);
            float n3 = float.Parse(txtn3.Text);
            float n4 = float.Parse(txtn4.Text);
            float n5 = float.Parse(txtn5.Text);
            float promedio = n1 + n2 + n3 + n4 + n5;
            float total = promedio / 5;

            lblpromedio.Text = ("Su promedio es: " + total);
            lblpromedio.Visible = true;

            if (total <= 1)
            {
                lbltexto.Text= ("Reprueba la materia sin lograr realizar proceso de recuperación.");
                lbltexto.Visible = true;
            }

            else
            {
            if (total <= 2.9)
            {
                lbltexto.Text = ("Reprueba la materia y puede hacer la habilitación");
                lbltexto.Visible = true;
            }
            else
            {
            if (total <= 3.9)
            {
                lbltexto.Text = ("Aprueba la materia con plan de mejora");
                lbltexto.Visible = true;
            }
            else
            {
            if (total <= 4.5)
            {
                  lbltexto.Text = ("Buen rendimiento");
                  lbltexto.Visible = true;
            }
            else
            {
            if (total <= 4.9)
            {
                  lbltexto.Text = ("Excelente");
                  lbltexto.Visible = true;
            }
            else
            {
            if (total == 5)
            {
                  lbltexto.Text = ("Graduado con honores");
                  lbltexto.Visible = true;

            }
            }
            }
            }
            }

            }




        }
    }
}
