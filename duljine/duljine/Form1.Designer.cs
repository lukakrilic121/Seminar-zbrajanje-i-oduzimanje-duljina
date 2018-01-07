namespace duljine
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IznosDuljine = new System.Windows.Forms.TextBox();
            this.IznosDuljine2 = new System.Windows.Forms.TextBox();
            this.ListaDuljina = new System.Windows.Forms.ListBox();
            this.ListaDuljine2 = new System.Windows.Forms.ListBox();
            this.ListaOperacije = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IzracunataVrijednost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Velicina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prva Duljina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Druga duljina";
            // 
            // IznosDuljine
            // 
            this.IznosDuljine.Location = new System.Drawing.Point(88, 33);
            this.IznosDuljine.Name = "IznosDuljine";
            this.IznosDuljine.Size = new System.Drawing.Size(60, 20);
            this.IznosDuljine.TabIndex = 2;
            // 
            // IznosDuljine2
            // 
            this.IznosDuljine2.Location = new System.Drawing.Point(245, 33);
            this.IznosDuljine2.Name = "IznosDuljine2";
            this.IznosDuljine2.Size = new System.Drawing.Size(79, 20);
            this.IznosDuljine2.TabIndex = 3;
            // 
            // ListaDuljina
            // 
            this.ListaDuljina.FormattingEnabled = true;
            this.ListaDuljina.Items.AddRange(new object[] {
            "m",
            "km",
            "cm",
            "mm",
            "feet",
            "inch",
            "yard"});
            this.ListaDuljina.Location = new System.Drawing.Point(88, 88);
            this.ListaDuljina.Name = "ListaDuljina";
            this.ListaDuljina.Size = new System.Drawing.Size(60, 95);
            this.ListaDuljina.TabIndex = 4;
            // 
            // ListaDuljine2
            // 
            this.ListaDuljine2.FormattingEnabled = true;
            this.ListaDuljine2.Items.AddRange(new object[] {
            "m",
            "km",
            "cm",
            "mm",
            "feet",
            "inch",
            "yard"});
            this.ListaDuljine2.Location = new System.Drawing.Point(245, 88);
            this.ListaDuljine2.Name = "ListaDuljine2";
            this.ListaDuljine2.Size = new System.Drawing.Size(59, 95);
            this.ListaDuljine2.TabIndex = 5;
            // 
            // ListaOperacije
            // 
            this.ListaOperacije.FormattingEnabled = true;
            this.ListaOperacije.Items.AddRange(new object[] {
            "Zbrajanje",
            "Oduzimanje"});
            this.ListaOperacije.Location = new System.Drawing.Point(164, 224);
            this.ListaOperacije.Name = "ListaOperacije";
            this.ListaOperacije.Size = new System.Drawing.Size(75, 30);
            this.ListaOperacije.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Izračunaj\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IzracunataVrijednost
            // 
            this.IzracunataVrijednost.Location = new System.Drawing.Point(154, 285);
            this.IzracunataVrijednost.Name = "IzracunataVrijednost";
            this.IzracunataVrijednost.Size = new System.Drawing.Size(75, 20);
            this.IzracunataVrijednost.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Operacije";
            // 
            // Velicina
            // 
            this.Velicina.AutoSize = true;
            this.Velicina.Location = new System.Drawing.Point(242, 292);
            this.Velicina.Name = "Velicina";
            this.Velicina.Size = new System.Drawing.Size(43, 13);
            this.Velicina.TabIndex = 10;
            this.Velicina.Text = "veličina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 321);
            this.Controls.Add(this.Velicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IzracunataVrijednost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaOperacije);
            this.Controls.Add(this.ListaDuljine2);
            this.Controls.Add(this.ListaDuljina);
            this.Controls.Add(this.IznosDuljine2);
            this.Controls.Add(this.IznosDuljine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IznosDuljine;
        private System.Windows.Forms.TextBox IznosDuljine2;
        private System.Windows.Forms.ListBox ListaDuljina;
        private System.Windows.Forms.ListBox ListaDuljine2;
        private System.Windows.Forms.ListBox ListaOperacije;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IzracunataVrijednost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Velicina;
    }
}

