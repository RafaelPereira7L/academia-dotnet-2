namespace WindowsForms
{
    partial class Form1
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
            this.label_nomeCompleto = new System.Windows.Forms.Label();
            this.textBox_nomeCompleto = new System.Windows.Forms.TextBox();
            this.btn_nomeCompleto = new System.Windows.Forms.Button();
            this.textBox_listaNomes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_nomeCompleto
            // 
            this.label_nomeCompleto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeCompleto.Location = new System.Drawing.Point(322, 0);
            this.label_nomeCompleto.Name = "label_nomeCompleto";
            this.label_nomeCompleto.Size = new System.Drawing.Size(131, 20);
            this.label_nomeCompleto.TabIndex = 0;
            this.label_nomeCompleto.Text = "Nome Completo";
            // 
            // textBox_nomeCompleto
            // 
            this.textBox_nomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nomeCompleto.Location = new System.Drawing.Point(294, 23);
            this.textBox_nomeCompleto.Name = "textBox_nomeCompleto";
            this.textBox_nomeCompleto.Size = new System.Drawing.Size(183, 20);
            this.textBox_nomeCompleto.TabIndex = 1;
            // 
            // btn_nomeCompleto
            // 
            this.btn_nomeCompleto.Location = new System.Drawing.Point(349, 49);
            this.btn_nomeCompleto.Name = "btn_nomeCompleto";
            this.btn_nomeCompleto.Size = new System.Drawing.Size(75, 23);
            this.btn_nomeCompleto.TabIndex = 2;
            this.btn_nomeCompleto.Text = "Enviar";
            this.btn_nomeCompleto.UseVisualStyleBackColor = true;
            this.btn_nomeCompleto.Click += new System.EventHandler(this.btn_nomeCompleto_Click);
            // 
            // textBox_listaNomes
            // 
            this.textBox_listaNomes.Enabled = false;
            this.textBox_listaNomes.Location = new System.Drawing.Point(255, 78);
            this.textBox_listaNomes.Multiline = true;
            this.textBox_listaNomes.Name = "textBox_listaNomes";
            this.textBox_listaNomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaNomes.Size = new System.Drawing.Size(273, 286);
            this.textBox_listaNomes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_listaNomes);
            this.Controls.Add(this.btn_nomeCompleto);
            this.Controls.Add(this.textBox_nomeCompleto);
            this.Controls.Add(this.label_nomeCompleto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox_listaNomes;

        private System.Windows.Forms.ListBox listBox_nomes;

        private System.Windows.Forms.Button btn_nomeCompleto;

        private System.Windows.Forms.Label label_nomeCompleto;
        private System.Windows.Forms.TextBox textBox_nomeCompleto;

        #endregion
    }
}