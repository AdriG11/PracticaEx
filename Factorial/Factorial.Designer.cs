namespace Factorial
{
    partial class Factorial
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
            btnCalcular = new Button();
            txtNumbers = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 95);
            label1.Name = "label1";
            label1.Size = new Size(339, 20);
            label1.TabIndex = 0;
            label1.Text = "INGRESE EL NUMERO A CALCULAR SU FACTORIAL";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(87, 235);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(212, 69);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNumbers
            // 
            txtNumbers.Location = new Point(130, 131);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(131, 27);
            txtNumbers.TabIndex = 2;
            // 
            // Factorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 389);
            Controls.Add(txtNumbers);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Name = "Factorial";
            Text = "Factorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCalcular;
        private TextBox txtNumbers;
    }
}