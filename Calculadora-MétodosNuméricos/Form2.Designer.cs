namespace Calculadora_MétodosNuméricos
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbBiseccion = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gbMetodos = new System.Windows.Forms.GroupBox();
            this.rbRegulaFalsi = new System.Windows.Forms.RadioButton();
            this.rbNewton = new System.Windows.Forms.RadioButton();
            this.rbSecante = new System.Windows.Forms.RadioButton();
            this.gbMetodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // rbBiseccion
            // 
            this.rbBiseccion.AutoSize = true;
            this.rbBiseccion.Location = new System.Drawing.Point(6, 25);
            this.rbBiseccion.Name = "rbBiseccion";
            this.rbBiseccion.Size = new System.Drawing.Size(87, 20);
            this.rbBiseccion.TabIndex = 2;
            this.rbBiseccion.TabStop = true;
            this.rbBiseccion.Text = "Bisección";
            this.rbBiseccion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbMetodos
            // 
            this.gbMetodos.Controls.Add(this.rbSecante);
            this.gbMetodos.Controls.Add(this.rbNewton);
            this.gbMetodos.Controls.Add(this.rbRegulaFalsi);
            this.gbMetodos.Controls.Add(this.rbBiseccion);
            this.gbMetodos.Location = new System.Drawing.Point(602, 107);
            this.gbMetodos.Name = "gbMetodos";
            this.gbMetodos.Size = new System.Drawing.Size(162, 150);
            this.gbMetodos.TabIndex = 4;
            this.gbMetodos.TabStop = false;
            this.gbMetodos.Text = "Método:";
            // 
            // rbRegulaFalsi
            // 
            this.rbRegulaFalsi.AutoSize = true;
            this.rbRegulaFalsi.Location = new System.Drawing.Point(6, 51);
            this.rbRegulaFalsi.Name = "rbRegulaFalsi";
            this.rbRegulaFalsi.Size = new System.Drawing.Size(104, 20);
            this.rbRegulaFalsi.TabIndex = 3;
            this.rbRegulaFalsi.TabStop = true;
            this.rbRegulaFalsi.Text = "Regula Falsi";
            this.rbRegulaFalsi.UseVisualStyleBackColor = true;
            // 
            // rbNewton
            // 
            this.rbNewton.AutoSize = true;
            this.rbNewton.Location = new System.Drawing.Point(6, 77);
            this.rbNewton.Name = "rbNewton";
            this.rbNewton.Size = new System.Drawing.Size(131, 20);
            this.rbNewton.TabIndex = 4;
            this.rbNewton.TabStop = true;
            this.rbNewton.Text = "Newton Raphson";
            this.rbNewton.UseVisualStyleBackColor = true;
            // 
            // rbSecante
            // 
            this.rbSecante.AutoSize = true;
            this.rbSecante.Location = new System.Drawing.Point(6, 103);
            this.rbSecante.Name = "rbSecante";
            this.rbSecante.Size = new System.Drawing.Size(78, 20);
            this.rbSecante.TabIndex = 5;
            this.rbSecante.TabStop = true;
            this.rbSecante.Text = "Secante";
            this.rbSecante.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMetodos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbMetodos.ResumeLayout(false);
            this.gbMetodos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBiseccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbMetodos;
        private System.Windows.Forms.RadioButton rbSecante;
        private System.Windows.Forms.RadioButton rbNewton;
        private System.Windows.Forms.RadioButton rbRegulaFalsi;
    }
}