
namespace _12_Rezystor
{
    partial class FormMain
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
            this.btOblicz = new System.Windows.Forms.Button();
            this.tbHelp = new System.Windows.Forms.TextBox();
            this.cbPasek2 = new System.Windows.Forms.ComboBox();
            this.cbPasek3 = new System.Windows.Forms.ComboBox();
            this.cbPasek4 = new System.Windows.Forms.ComboBox();
            this.cbPasek1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblWynik = new System.Windows.Forms.Label();
            this.lblPasek1 = new System.Windows.Forms.Label();
            this.lblPasek2 = new System.Windows.Forms.Label();
            this.lblPasek3 = new System.Windows.Forms.Label();
            this.lblPasek4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOblicz
            // 
            this.btOblicz.Location = new System.Drawing.Point(12, 332);
            this.btOblicz.Name = "btOblicz";
            this.btOblicz.Size = new System.Drawing.Size(382, 106);
            this.btOblicz.TabIndex = 1;
            this.btOblicz.Text = "Oblicz";
            this.btOblicz.UseVisualStyleBackColor = true;
            this.btOblicz.Click += new System.EventHandler(this.btOblicz_Click);
            // 
            // tbHelp
            // 
            this.tbHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHelp.Location = new System.Drawing.Point(149, 298);
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.Size = new System.Drawing.Size(245, 31);
            this.tbHelp.TabIndex = 2;
            // 
            // cbPasek2
            // 
            this.cbPasek2.FormattingEnabled = true;
            this.cbPasek2.Location = new System.Drawing.Point(109, 55);
            this.cbPasek2.Name = "cbPasek2";
            this.cbPasek2.Size = new System.Drawing.Size(91, 21);
            this.cbPasek2.TabIndex = 3;
            this.cbPasek2.Tag = "2";
            this.cbPasek2.SelectedIndexChanged += new System.EventHandler(this.cbPasek_SelectedIndexChanged);
            // 
            // cbPasek3
            // 
            this.cbPasek3.FormattingEnabled = true;
            this.cbPasek3.Location = new System.Drawing.Point(206, 55);
            this.cbPasek3.Name = "cbPasek3";
            this.cbPasek3.Size = new System.Drawing.Size(91, 21);
            this.cbPasek3.TabIndex = 4;
            this.cbPasek3.Tag = "3";
            this.cbPasek3.SelectedIndexChanged += new System.EventHandler(this.cbPasek_SelectedIndexChanged);
            // 
            // cbPasek4
            // 
            this.cbPasek4.FormattingEnabled = true;
            this.cbPasek4.Location = new System.Drawing.Point(303, 55);
            this.cbPasek4.Name = "cbPasek4";
            this.cbPasek4.Size = new System.Drawing.Size(91, 21);
            this.cbPasek4.TabIndex = 5;
            this.cbPasek4.Tag = "4";
            this.cbPasek4.SelectedIndexChanged += new System.EventHandler(this.cbPasek_SelectedIndexChanged);
            // 
            // cbPasek1
            // 
            this.cbPasek1.FormattingEnabled = true;
            this.cbPasek1.Location = new System.Drawing.Point(12, 55);
            this.cbPasek1.Name = "cbPasek1";
            this.cbPasek1.Size = new System.Drawing.Size(91, 21);
            this.cbPasek1.TabIndex = 0;
            this.cbPasek1.Tag = "1";
            this.cbPasek1.SelectedIndexChanged += new System.EventHandler(this.cbPasek_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 210);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(109, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 210);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(206, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(91, 210);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(303, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(91, 210);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(12, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 20);
            this.panel5.TabIndex = 9;
            this.panel5.Visible = false;
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWynik.Location = new System.Drawing.Point(7, 301);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(136, 25);
            this.lblWynik.TabIndex = 10;
            this.lblWynik.Text = "Rezystancja:";
            // 
            // lblPasek1
            // 
            this.lblPasek1.AutoSize = true;
            this.lblPasek1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasek1.Location = new System.Drawing.Point(7, 27);
            this.lblPasek1.Name = "lblPasek1";
            this.lblPasek1.Size = new System.Drawing.Size(90, 25);
            this.lblPasek1.TabIndex = 11;
            this.lblPasek1.Text = "Pasek 1";
            // 
            // lblPasek2
            // 
            this.lblPasek2.AutoSize = true;
            this.lblPasek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasek2.Location = new System.Drawing.Point(104, 27);
            this.lblPasek2.Name = "lblPasek2";
            this.lblPasek2.Size = new System.Drawing.Size(90, 25);
            this.lblPasek2.TabIndex = 12;
            this.lblPasek2.Text = "Pasek 2";
            // 
            // lblPasek3
            // 
            this.lblPasek3.AutoSize = true;
            this.lblPasek3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasek3.Location = new System.Drawing.Point(201, 27);
            this.lblPasek3.Name = "lblPasek3";
            this.lblPasek3.Size = new System.Drawing.Size(90, 25);
            this.lblPasek3.TabIndex = 13;
            this.lblPasek3.Text = "Pasek 3";
            // 
            // lblPasek4
            // 
            this.lblPasek4.AutoSize = true;
            this.lblPasek4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasek4.Location = new System.Drawing.Point(298, 27);
            this.lblPasek4.Name = "lblPasek4";
            this.lblPasek4.Size = new System.Drawing.Size(90, 25);
            this.lblPasek4.TabIndex = 14;
            this.lblPasek4.Text = "Pasek 4";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.lblPasek4);
            this.Controls.Add(this.lblPasek3);
            this.Controls.Add(this.lblPasek2);
            this.Controls.Add(this.lblPasek1);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbPasek1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbPasek3);
            this.Controls.Add(this.cbPasek4);
            this.Controls.Add(this.cbPasek2);
            this.Controls.Add(this.tbHelp);
            this.Controls.Add(this.btOblicz);
            this.Name = "FormMain";
            this.Text = "Kalkulator rezystancji";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btOblicz;
        private System.Windows.Forms.TextBox tbHelp;
        private System.Windows.Forms.ComboBox cbPasek2;
        private System.Windows.Forms.ComboBox cbPasek3;
        private System.Windows.Forms.ComboBox cbPasek4;
        private System.Windows.Forms.ComboBox cbPasek1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.Label lblPasek1;
        private System.Windows.Forms.Label lblPasek2;
        private System.Windows.Forms.Label lblPasek3;
        private System.Windows.Forms.Label lblPasek4;
    }
}

