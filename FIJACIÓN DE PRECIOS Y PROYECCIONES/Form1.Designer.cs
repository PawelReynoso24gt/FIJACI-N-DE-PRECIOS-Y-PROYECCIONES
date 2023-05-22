namespace FIJACIÓN_DE_PRECIOS_Y_PROYECCIONES
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            buttonFijacion = new Button();
            buttonBase = new Button();
            buttonProyeccion = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonFijacion
            // 
            buttonFijacion.BackColor = Color.Snow;
            buttonFijacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFijacion.ForeColor = SystemColors.MenuHighlight;
            buttonFijacion.Location = new Point(103, 55);
            buttonFijacion.Name = "buttonFijacion";
            buttonFijacion.Size = new Size(87, 55);
            buttonFijacion.TabIndex = 0;
            buttonFijacion.Text = "Fijación de Precios";
            buttonFijacion.UseVisualStyleBackColor = false;
            buttonFijacion.Click += button1_Click;
            // 
            // buttonBase
            // 
            buttonBase.BackColor = Color.Snow;
            buttonBase.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBase.ForeColor = SystemColors.MenuHighlight;
            buttonBase.Location = new Point(383, 55);
            buttonBase.Name = "buttonBase";
            buttonBase.Size = new Size(87, 55);
            buttonBase.TabIndex = 1;
            buttonBase.Text = "Base 1";
            buttonBase.UseVisualStyleBackColor = false;
            buttonBase.Click += buttonBase_Click;
            // 
            // buttonProyeccion
            // 
            buttonProyeccion.Location = new Point(266, 183);
            buttonProyeccion.Name = "buttonProyeccion";
            buttonProyeccion.Size = new Size(75, 23);
            buttonProyeccion.TabIndex = 2;
            buttonProyeccion.Text = "button3";
            buttonProyeccion.UseVisualStyleBackColor = true;
            buttonProyeccion.Click += buttonProyeccion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(386, 17);
            label1.TabIndex = 3;
            label1.Text = "FIJACIÓN DE PRECIOS || BASE 1 || PROYECCIONES DE VENTAS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.online_shop;
            pictureBox1.Location = new Point(103, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.accounting;
            pictureBox2.Location = new Point(383, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(554, 241);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(buttonProyeccion);
            Controls.Add(buttonBase);
            Controls.Add(buttonFijacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            Text = "Menú Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFijacion;
        private Button buttonBase;
        private Button buttonProyeccion;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}