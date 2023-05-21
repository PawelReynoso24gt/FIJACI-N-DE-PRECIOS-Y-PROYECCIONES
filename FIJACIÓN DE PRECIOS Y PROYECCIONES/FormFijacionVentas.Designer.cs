namespace FIJACIÓN_DE_PRECIOS_Y_PROYECCIONES
{
    partial class FormFijacionVentas
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxPV = new TextBox();
            textBoxCV = new TextBox();
            textBoxMU = new TextBox();
            textBoxU = new TextBox();
            buttonCalcular = new Button();
            checkBoxUtilidad = new CheckBox();
            toolTip1 = new ToolTip(components);
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelFisicas = new Label();
            label9 = new Label();
            textBoxGO = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 33);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Precio de Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 79);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Costo Variable";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 121);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Margen de Utilidad";
            // 
            // textBoxPV
            // 
            textBoxPV.Location = new Point(146, 30);
            textBoxPV.Name = "textBoxPV";
            textBoxPV.Size = new Size(100, 23);
            textBoxPV.TabIndex = 4;
            // 
            // textBoxCV
            // 
            textBoxCV.Location = new Point(146, 76);
            textBoxCV.Name = "textBoxCV";
            textBoxCV.Size = new Size(100, 23);
            textBoxCV.TabIndex = 5;
            // 
            // textBoxMU
            // 
            textBoxMU.Location = new Point(146, 118);
            textBoxMU.Name = "textBoxMU";
            textBoxMU.Size = new Size(100, 23);
            textBoxMU.TabIndex = 6;
            // 
            // textBoxU
            // 
            textBoxU.Location = new Point(146, 205);
            textBoxU.Name = "textBoxU";
            textBoxU.Size = new Size(100, 23);
            textBoxU.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(323, 287);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "CALCULAR";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // checkBoxUtilidad
            // 
            checkBoxUtilidad.AutoSize = true;
            checkBoxUtilidad.Location = new Point(73, 207);
            checkBoxUtilidad.Name = "checkBoxUtilidad";
            checkBoxUtilidad.Size = new Size(67, 19);
            checkBoxUtilidad.TabIndex = 9;
            checkBoxUtilidad.Text = "Utilidad";
            checkBoxUtilidad.UseVisualStyleBackColor = true;
            checkBoxUtilidad.CheckedChanged += checkBoxUtilidad_CheckedChanged;
            checkBoxUtilidad.MouseHover += checkBoxUtilidad_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 53);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 11;
            label4.Text = "UNIDADES FÍSICAS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(445, 151);
            label5.Name = "label5";
            label5.Size = new Size(141, 15);
            label5.TabIndex = 12;
            label5.Text = "UNIDADES MONETARIAS:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 84);
            label6.Name = "label6";
            label6.Size = new Size(173, 15);
            label6.TabIndex = 13;
            label6.Text = "UNIDADES FÍSICAS + UTILIDAD:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 118);
            label7.Name = "label7";
            label7.Size = new Size(240, 15);
            label7.TabIndex = 14;
            label7.Text = "UNIDADES FÍSICAS DESPUES DE IMPUESTOS:\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(614, 30);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 15;
            label8.Text = "Unidad (Q)";
            // 
            // labelFisicas
            // 
            labelFisicas.AutoSize = true;
            labelFisicas.Location = new Point(592, 53);
            labelFisicas.Name = "labelFisicas";
            labelFisicas.Size = new Size(13, 15);
            labelFisicas.TabIndex = 16;
            labelFisicas.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 165);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 17;
            label9.Text = "Gastos Operativos";
            // 
            // textBoxGO
            // 
            textBoxGO.Location = new Point(146, 162);
            textBoxGO.Name = "textBoxGO";
            textBoxGO.Size = new Size(100, 23);
            textBoxGO.TabIndex = 18;
            // 
            // FormFijacionVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 450);
            Controls.Add(textBoxGO);
            Controls.Add(label9);
            Controls.Add(labelFisicas);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBoxUtilidad);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxU);
            Controls.Add(textBoxMU);
            Controls.Add(textBoxCV);
            Controls.Add(textBoxPV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFijacionVentas";
            Text = "Fijación de Precios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPV;
        private TextBox textBoxCV;
        private TextBox textBoxMU;
        private TextBox textBoxU;
        private Button buttonCalcular;
        private CheckBox checkBoxUtilidad;
        private ToolTip toolTip1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelFisicas;
        private Label label9;
        private TextBox textBoxGO;
    }
}