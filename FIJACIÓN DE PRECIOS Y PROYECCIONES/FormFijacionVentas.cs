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

namespace FIJACIÓN_DE_PRECIOS_Y_PROYECCIONES
{
    public partial class FormFijacionVentas : Form
    {
        double pv, cv, mu, u, go;
        float isrformu = 0.25f;
        public FormFijacionVentas()
        {
            InitializeComponent();
            textBoxU.Enabled = false;
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

            int ufu = UNISIFU();
            labelFisicasU.Text = ufu.ToString();
        }
        private int UNIFIS()
        {
            int uf = (int)(go / (pv - cv));
            return uf;
        }

        private int UNISIFU()
        {
            int ufu = (int)((go + u) / (pv - cv));
            return ufu;
        }
    }
}
