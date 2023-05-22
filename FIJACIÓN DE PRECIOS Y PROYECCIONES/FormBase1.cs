using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIJACIÓN_DE_PRECIOS_Y_PROYECCIONES
{
    public partial class FormBase1 : Form
    {
        double pv, cv, mu, u, go;
        double isrformu = 0.25;
        double PRpv = 100;
        public FormBase1()
        {
            InitializeComponent();
            textBoxPV.Enabled = false;
            textBoxMU.Enabled = false;
            textBoxPV.Text = PRpv.ToString();
        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMU.Text))
            {
                cv = double.Parse(textBoxCV.Text);
                cv = (cv / 100);
                go = double.Parse(textBoxGO.Text);
                u = double.Parse(textBoxUtilidad.Text);

                double base1 = BASE1();
                labelBase1.Text = base1.ToString("N2");

                double base1uti = BASE1UTILIDAD();
                labelBase1Utilidad.Text = base1uti.ToString("N2");
            }
            else
            {
                go = double.Parse(textBoxGO.Text);
                u = double.Parse(textBoxUtilidad.Text);
                pv = double.Parse(textBoxPV.Text);
                mu = double.Parse(textBoxMU.Text);
                cv = pv - mu;
                textBoxCV.Text = cv.ToString();
                cv = (cv / 100);

                double base1 = BASE1();
                labelBase1.Text = base1.ToString("N2");

                double base1uti = BASE1UTILIDAD();
                labelBase1Utilidad.Text = base1uti.ToString("N2");
            }
        }

        private void buttonComprobar_Click(object sender, EventArgs e)
        {
            go = double.Parse(textBoxGO.Text);
            labelGOB1.Text = "Q " + go.ToString("N2");
            labelGOB1U.Text = "Q " + go.ToString("N2");

            double ventasbase1 = BASE1();
            double ventasbase1u = BASE1UTILIDAD();
            labelVentasB1.Text = "Q " + ventasbase1.ToString("N2");
            labelVentasB1U.Text = "Q " + ventasbase1u.ToString("N2");

            cv = double.Parse(textBoxCV.Text);
            cv = (cv / 100);

            double cvbase1 = ventasbase1 * cv;
            double cvbase1u = ventasbase1u * cv;
            labelCVB1.Text = "Q " + cvbase1.ToString("N2");
            labelCVB1U.Text = "Q " + cvbase1u.ToString("N2");

            double ubrutabase1 = ventasbase1 - cvbase1;
            double ubrutabase1u = ventasbase1u - cvbase1u;
            labelUBrutaB1.Text = "Q " + ubrutabase1.ToString("N2");
            labelUBrutaB1U.Text = "Q " + ubrutabase1u.ToString("N2");

            double uaib1 = ubrutabase1u - go;
            labelUAIB1U.Text = "Q " + uaib1.ToString("N2");

            double uaib1u = ubrutabase1u - go;
            labelUAIB1U.Text = "Q " + uaib1u.ToString("N2");

            if (((0.25 * uaib1u) / ventasbase1u) < 0.07)
            {
                double isrb1u = 0.25 * uaib1u;
                labelISRB1U.Text = isrb1u.ToString("N2");

                double unetab1u = uaib1u - isrb1u;
                labelNETAB1U.Text = unetab1u.ToString("N2");
            }
            else
            {
                double isrb1u = 0.07 * ventasbase1u;
                labelISRB1U.Text = isrb1u.ToString("N2");

                double unetab1u = uaib1u - isrb1u;
                labelNETAB1U.Text = unetab1u.ToString("N2");
            }
        }

        private void checkBoxCalculoCV_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(checkBoxCalculoCV, "Si no cuenta con el Costo Variable puede calcularlo aquí");
        }

        private void checkBoxCalculoCV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCalculoCV.Checked)
            {
                textBoxPV.Enabled = true;
                textBoxMU.Enabled = true;
            }
            else
            {
                textBoxPV.Enabled = false;
                textBoxMU.Enabled = false;
            }
        }

        private double BASE1()
        {
            double base1 = (go / (1 - (cv / 1)));
            return base1;
        }

        private double BASE1UTILIDAD()
        {
            double base1uti = ((go + (u / (1 - isrformu))) / (1 - (cv / 1)));
            return base1uti;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }
    }
}
