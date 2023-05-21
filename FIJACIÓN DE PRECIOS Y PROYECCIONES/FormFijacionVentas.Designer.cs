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
            labelFisicas = new Label();
            label9 = new Label();
            textBoxGO = new TextBox();
            label10 = new Label();
            textBoxPRpv = new TextBox();
            textBoxPRcv = new TextBox();
            textBoxPRmu = new TextBox();
            labelFisicasU = new Label();
            labelFisicasISR = new Label();
            labelMonetarias = new Label();
            checkBoxPorciento = new CheckBox();
            toolTip2 = new ToolTip(components);
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 63);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Precio de Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 109);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Costo Variable";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 151);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Margen de Utilidad";
            // 
            // textBoxPV
            // 
            textBoxPV.Location = new Point(146, 60);
            textBoxPV.Name = "textBoxPV";
            textBoxPV.Size = new Size(100, 23);
            textBoxPV.TabIndex = 4;
            // 
            // textBoxCV
            // 
            textBoxCV.Location = new Point(146, 106);
            textBoxCV.Name = "textBoxCV";
            textBoxCV.Size = new Size(100, 23);
            textBoxCV.TabIndex = 5;
            // 
            // textBoxMU
            // 
            textBoxMU.Location = new Point(146, 148);
            textBoxMU.Name = "textBoxMU";
            textBoxMU.Size = new Size(100, 23);
            textBoxMU.TabIndex = 6;
            // 
            // textBoxU
            // 
            textBoxU.Location = new Point(146, 235);
            textBoxU.Name = "textBoxU";
            textBoxU.Size = new Size(100, 23);
            textBoxU.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(292, 235);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(79, 23);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "CALCULAR";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // checkBoxUtilidad
            // 
            checkBoxUtilidad.AutoSize = true;
            checkBoxUtilidad.Location = new Point(73, 237);
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
            label4.Location = new Point(563, 53);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 11;
            label4.Text = "UNIDADES FÍSICAS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(531, 151);
            label5.Name = "label5";
            label5.Size = new Size(141, 15);
            label5.TabIndex = 12;
            label5.Text = "UNIDADES MONETARIAS:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(499, 84);
            label6.Name = "label6";
            label6.Size = new Size(173, 15);
            label6.TabIndex = 13;
            label6.Text = "UNIDADES FÍSICAS + UTILIDAD:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 118);
            label7.Name = "label7";
            label7.Size = new Size(240, 15);
            label7.TabIndex = 14;
            label7.Text = "UNIDADES FÍSICAS DESPUES DE IMPUESTOS:\r\n";
            // 
            // labelFisicas
            // 
            labelFisicas.AutoSize = true;
            labelFisicas.Location = new Point(678, 53);
            labelFisicas.Name = "labelFisicas";
            labelFisicas.Size = new Size(13, 15);
            labelFisicas.TabIndex = 16;
            labelFisicas.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 195);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 17;
            label9.Text = "Gastos Operativos";
            // 
            // textBoxGO
            // 
            textBoxGO.Location = new Point(146, 192);
            textBoxGO.Name = "textBoxGO";
            textBoxGO.Size = new Size(100, 23);
            textBoxGO.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(166, 30);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 19;
            label10.Text = "Unidad (Q)";
            // 
            // textBoxPRpv
            // 
            textBoxPRpv.Location = new Point(271, 60);
            textBoxPRpv.Name = "textBoxPRpv";
            textBoxPRpv.Size = new Size(100, 23);
            textBoxPRpv.TabIndex = 21;
            // 
            // textBoxPRcv
            // 
            textBoxPRcv.Location = new Point(271, 106);
            textBoxPRcv.Name = "textBoxPRcv";
            textBoxPRcv.Size = new Size(100, 23);
            textBoxPRcv.TabIndex = 22;
            // 
            // textBoxPRmu
            // 
            textBoxPRmu.Location = new Point(271, 148);
            textBoxPRmu.Name = "textBoxPRmu";
            textBoxPRmu.Size = new Size(100, 23);
            textBoxPRmu.TabIndex = 23;
            // 
            // labelFisicasU
            // 
            labelFisicasU.AutoSize = true;
            labelFisicasU.Location = new Point(678, 84);
            labelFisicasU.Name = "labelFisicasU";
            labelFisicasU.Size = new Size(13, 15);
            labelFisicasU.TabIndex = 24;
            labelFisicasU.Text = "0";
            // 
            // labelFisicasISR
            // 
            labelFisicasISR.AutoSize = true;
            labelFisicasISR.Location = new Point(678, 118);
            labelFisicasISR.Name = "labelFisicasISR";
            labelFisicasISR.Size = new Size(13, 15);
            labelFisicasISR.TabIndex = 25;
            labelFisicasISR.Text = "0";
            // 
            // labelMonetarias
            // 
            labelMonetarias.AutoSize = true;
            labelMonetarias.Location = new Point(678, 151);
            labelMonetarias.Name = "labelMonetarias";
            labelMonetarias.Size = new Size(40, 15);
            labelMonetarias.TabIndex = 26;
            labelMonetarias.Text = "Q 0.00";
            // 
            // checkBoxPorciento
            // 
            checkBoxPorciento.AutoSize = true;
            checkBoxPorciento.Location = new Point(288, 29);
            checkBoxPorciento.Name = "checkBoxPorciento";
            checkBoxPorciento.Size = new Size(85, 19);
            checkBoxPorciento.TabIndex = 27;
            checkBoxPorciento.Text = "Unidad (%)";
            checkBoxPorciento.UseVisualStyleBackColor = true;
            checkBoxPorciento.CheckedChanged += checkBoxPorciento_CheckedChanged;
            checkBoxPorciento.MouseHover += checkBoxPorciento_MouseHover;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 332);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 28;
            label8.Text = "COMPROBACIONES";
            // 
            // button1
            // 
            button1.Location = new Point(563, 237);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 29;
            button1.Text = "COMPROBAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormFijacionVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 617);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(checkBoxPorciento);
            Controls.Add(labelMonetarias);
            Controls.Add(labelFisicasISR);
            Controls.Add(labelFisicasU);
            Controls.Add(textBoxPRmu);
            Controls.Add(textBoxPRcv);
            Controls.Add(textBoxPRpv);
            Controls.Add(label10);
            Controls.Add(textBoxGO);
            Controls.Add(label9);
            Controls.Add(labelFisicas);
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
        private Label labelFisicas;
        private Label label9;
        private TextBox textBoxGO;
        private Label label10;
        private TextBox textBoxPRpv;
        private TextBox textBoxPRcv;
        private TextBox textBoxPRmu;
        private Label labelFisicasU;
        private Label labelFisicasISR;
        private Label labelMonetarias;
        private CheckBox checkBoxPorciento;
        private ToolTip toolTip2;
        private Label label8;
        private Button button1;
    }
}