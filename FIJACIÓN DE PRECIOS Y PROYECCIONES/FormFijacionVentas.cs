using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.CodeAnalysis;

namespace FIJACIÓN_DE_PRECIOS_Y_PROYECCIONES
{
    public partial class FormFijacionVentas : Form
    {
        double pv, cv, mu, u, go;
        double isrformu = 0.25;
        double PRpv = 100, PRcv, PRmu;
        public FormFijacionVentas()
        {
            InitializeComponent();
            textBoxU.Enabled = false;
            textBoxPRpv.Enabled = false;
            textBoxPRcv.Enabled = false;
            textBoxPRmu.Enabled = false;
            textBoxPRpv.Text = PRpv.ToString();
        }

        private void checkBoxUtilidad_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(checkBoxUtilidad, "Si tiene una Utilidad propuesta puede usarla accediendo aquí");
        }

        private void checkBoxUtilidad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUtilidad.Checked)
            {
                textBoxU.Enabled = true;
            }
            else
            {
                textBoxU.Enabled = false;
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPRcv.Text) && string.IsNullOrEmpty(textBoxPRmu.Text))
            {
                pv = double.Parse(textBoxPV.Text);
                cv = double.Parse(textBoxCV.Text);
                mu = double.Parse(textBoxMU.Text);
                go = double.Parse(textBoxGO.Text);

                int uf = UNIFIS();
                labelFisicas.Text = uf.ToString();

                if (string.IsNullOrEmpty(textBoxU.Text))
                {
                    u = (pv * uf) * 0.50;
                }
                else
                {
                    u = double.Parse(textBoxU.Text);
                }

                int ufu = UNIFISU();
                labelFisicasU.Text = ufu.ToString();

                int ufisr = UNIFISISR();
                labelFisicasISR.Text = ufisr.ToString();

                double ufimon = UNIMON();
                labelMonetarias.Text = "Q " + ufimon.ToString();
            }
            else
            {
                PORCENTAJES();
                if (string.IsNullOrEmpty(textBoxMU.Text))
                {
                    cv = double.Parse(textBoxCV.Text);
                    mu = ((cv * PRmu) / PRcv);
                    textBoxMU.Text = mu.ToString();
                    //Console.WriteLine("el mu es"+mu);

                    pv = cv + mu;
                    textBoxPV.Text = pv.ToString();
                    //Console.WriteLine("el pv es"+pv);
                }
                else if (string.IsNullOrEmpty(textBoxCV.Text))
                {
                    mu = double.Parse(textBoxMU.Text);
                    cv = ((mu * PRcv) / PRmu);
                    textBoxCV.Text = cv.ToString();
                    //Console.WriteLine("el cv es"+cv);

                    pv = cv + mu;
                    textBoxPV.Text = pv.ToString();
                    //Console.WriteLine("el pv es" +pv);
                }
                go = double.Parse(textBoxGO.Text);

                int uf = UNIFIS();
                labelFisicas.Text = uf.ToString();

                if (string.IsNullOrEmpty(textBoxU.Text))
                {
                    u = (pv * uf) * 0.50;
                }
                else
                {
                    u = double.Parse(textBoxU.Text);
                }

                int ufu = UNIFISU();
                labelFisicasU.Text = ufu.ToString();

                int ufisr = UNIFISISR();
                labelFisicasISR.Text = ufisr.ToString();

                double ufimon = UNIMON();
                labelMonetarias.Text = "Q " + ufimon.ToString();
            }
        }
        private int UNIFIS()
        {
            int uf = (int)(go / (pv - cv));
            return uf;
        }

        private int UNIFISU()
        {
            int ufu = (int)((go + u) / (pv - cv));
            return ufu;
        }

        private int UNIFISISR()
        {
            int ufisr = (int)((go + (u / (1 - isrformu))) / (pv - cv));
            return ufisr;
        }

        private double UNIMON()
        {
            double ufimon = (go / (1 - (cv / pv)));
            return ufimon;
        }

        private void checkBoxPorciento_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(checkBoxUtilidad, "Si usará porcentajes puede usarlos accediendo aquí");
        }

        private void checkBoxPorciento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPorciento.Checked)
            {
                textBoxPRpv.Enabled = true;
                textBoxPRcv.Enabled = true;
                textBoxPRmu.Enabled = true;
            }
            else
            {
                textBoxPRpv.Enabled = false;
                textBoxPRcv.Enabled = false;
                textBoxPRmu.Enabled = false;
            }
        }

        private double PORCENTAJES()
        {
            if (string.IsNullOrEmpty(textBoxPRcv.Text))
            {
                PRmu = double.Parse(textBoxPRmu.Text);
                PRcv = PRpv - PRmu;
                textBoxPRcv.Text = PRcv.ToString();
                return PRcv;
            }
            if (string.IsNullOrEmpty(textBoxPRmu.Text))
            {
                PRcv = double.Parse(textBoxPRcv.Text);
                PRmu = PRpv - PRcv;
                textBoxPRmu.Text = PRmu.ToString();
                return PRmu;
            }
            return 0; //por si ninguna se cumple
        }
    }
}
