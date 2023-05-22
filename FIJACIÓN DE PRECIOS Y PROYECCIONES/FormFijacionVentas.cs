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

        private void button1_Click(object sender, EventArgs e)
        {
            //UF
            go = double.Parse(textBoxGO.Text);
            labelGOUF.Text = "Q " + go.ToString();
            pv = double.Parse(textBoxPV.Text);
            cv = double.Parse(textBoxCV.Text);

            int uf = UNIFIS();

            double ventasuf = pv * uf;
            double costovaruf = cv * uf;
            labelVentasUF.Text = "Q " + ventasuf.ToString();
            labelCVUF.Text = "Q " + costovaruf.ToString();

            double ubrutauf = ventasuf - costovaruf;
            labelUBrutaUF.Text = "Q " + ubrutauf.ToString();

            double uaiuf = ubrutauf - go;
            labelUAIUF.Text = "Q " + uaiuf.ToString();

            //UFU
            labelGOUFU.Text = "Q " + go.ToString();

            if (string.IsNullOrEmpty(textBoxU.Text))
            {
                u = (pv * uf) * 0.50;
            }
            else
            {
                u = double.Parse(textBoxU.Text);
            }

            int ufu = UNIFISU();

            double ventasufu = pv * ufu;
            double costovarufu = cv * ufu;
            labelVentasUFU.Text = "Q" + ventasufu.ToString();
            labelCVUFU.Text = "Q" + costovarufu.ToString();
            
            double ubrutaufu = ventasufu - costovarufu;
            labelUBrutaUFU.Text = "Q " + ubrutaufu.ToString();

            double uaiufu = ubrutaufu - go;
            labelUAIUFU.Text = "Q " + uaiufu.ToString();

            if(((0.25 * uaiufu) / ventasufu) < 0.07)
            {
                double isrufu = 0.25 * uaiufu;
                labelISRUFU.Text = "Q " + isrufu.ToString();

                double utineta = uaiufu - isrufu;
                labelNETAUFU.Text = "Q " + utineta.ToString();
            }
            else
            {
                double isrufu = 0.07 * ventasufu;
                labelISRUFU.Text = "Q " + isrufu.ToString();

                double utineta = uaiufu - isrufu;
                labelNETAUFU.Text = "Q " + utineta.ToString();
            }

            //UFUISR
            labelGOUFISR.Text = "Q " + go.ToString();

            int ufisr = UNIFISISR();

            double ventasisr = pv * ufisr;
            double costovarisr = cv * ufisr;
            labelVentasUFISR.Text = "Q " + ventasisr.ToString();
            labelCVUFISR.Text = "Q " + costovarisr.ToString();

            double ubrutaisr = ventasisr - costovarisr;
            labelUBrutaUFISR.Text= "Q " + ubrutaisr.ToString();

            double uaiisr = ubrutaisr - go;
            labelUAIUFISR.Text = "Q " + uaiisr.ToString();

            if (((0.25 * uaiisr) / ventasisr) < 0.07)
            {
                double isrisr = 0.25 * uaiisr;
                labelISRUFISR.Text = "Q " + isrisr.ToString();

                double utinetaisr = uaiisr - isrisr;
                labelNETAUFISR.Text = "Q " + utinetaisr.ToString();
            }
            else
            {
                double isrisr = 0.07 * ventasisr;
                labelISRUFU.Text = "Q " + isrisr.ToString();

                double utinetaisr = uaiisr - isrisr;
                labelNETAUFISR.Text = "Q " + utinetaisr.ToString();
            }

            //MONETARIOS
            double ufimon = UNIMON();
            labelGOMON.Text = "Q " + go.ToString();
            double porcentajeCV = double.Parse(textBoxPRcv.Text);

            double ventasmon = ufimon;
            double costovarmon = (ufimon * (porcentajeCV/100));
            labelVentasMON.Text = "Q " + ventasmon.ToString();
            labelCVMON.Text = "Q " + costovarmon.ToString();

            double ubrutamon = ventasmon - costovarmon;
            labelUBrutaMON.Text = "Q " + ubrutamon.ToString();

            double uaimon = ubrutamon - go;
            labelUAIMON.Text = "Q " + uaimon.ToString();
        }
    }
}
