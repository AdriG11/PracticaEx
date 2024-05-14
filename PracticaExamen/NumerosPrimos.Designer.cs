namespace PracticaExamen
{
    partial class NumerosPrimos
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
            label1 = new Label();
            label2 = new Label();
            txtInicio = new TextBox();
            txtFin = new TextBox();
            btnCalcular = new Button();
            txtPrimos = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 44);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 138);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero Fin";
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(169, 44);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(131, 27);
            txtInicio.TabIndex = 2;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(169, 131);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(131, 27);
            txtFin.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(27, 218);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(123, 53);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPrimos
            // 
            txtPrimos.Location = new Point(187, 231);
            txtPrimos.Multiline = true;
            txtPrimos.Name = "txtPrimos";
            txtPrimos.Size = new Size(173, 48);
            txtPrimos.TabIndex = 5;
            // 
            // NumerosPrimos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 320);
            Controls.Add(txtPrimos);
            Controls.Add(btnCalcular);
            Controls.Add(txtFin);
            Controls.Add(txtInicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NumerosPrimos";
            Text = "NumerosPrimos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtInicio;
        private TextBox txtFin;
        private Button btnCalcular;
        private TextBox txtPrimos;
    }
}