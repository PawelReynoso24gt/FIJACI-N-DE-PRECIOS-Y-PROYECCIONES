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
            buttonFijacion = new Button();
            buttonBase = new Button();
            buttonProyeccion = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonFijacion
            // 
            buttonFijacion.Location = new Point(234, 149);
            buttonFijacion.Name = "buttonFijacion";
            buttonFijacion.Size = new Size(75, 23);
            buttonFijacion.TabIndex = 0;
            buttonFijacion.Text = "button1";
            buttonFijacion.UseVisualStyleBackColor = true;
            buttonFijacion.Click += button1_Click;
            // 
            // buttonBase
            // 
            buttonBase.Location = new Point(400, 149);
            buttonBase.Name = "buttonBase";
            buttonBase.Size = new Size(75, 23);
            buttonBase.TabIndex = 1;
            buttonBase.Text = "button2";
            buttonBase.UseVisualStyleBackColor = true;
            buttonBase.Click += buttonBase_Click;
            // 
            // buttonProyeccion
            // 
            buttonProyeccion.Location = new Point(587, 149);
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 3;
            label1.Text = "MENÚ DE OPCIONES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 121);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "Fijación de Precios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 121);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Base 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(585, 121);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 6;
            label4.Text = "Proyecciones";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonProyeccion);
            Controls.Add(buttonBase);
            Controls.Add(buttonFijacion);
            Name = "FormMenu";
            Text = "Menú Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFijacion;
        private Button buttonBase;
        private Button buttonProyeccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}