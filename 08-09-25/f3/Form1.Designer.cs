namespace f3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.Cbe = new System.Windows.Forms.ComboBox();
            this.NoUD = new System.Windows.Forms.NumericUpDown();
            this.Gbe = new System.Windows.Forms.GroupBox();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.RbMale = new System.Windows.Forms.RadioButton();
            this.Chbe = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();

            this.ClientSize = new System.Drawing.Size(420, 380);
            this.Name = "Form1";
            this.Text = "Demo Control";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.Cbe.FormattingEnabled = true;
            this.Cbe.Location = new System.Drawing.Point(30, 30);
            this.Cbe.Name = "Cbe";
            this.Cbe.Size = new System.Drawing.Size(200, 24);
            this.Cbe.TabIndex = 0;

            this.NoUD.Location = new System.Drawing.Point(30, 70);
            this.NoUD.Maximum = 100;
            this.NoUD.Name = "NoUD";
            this.NoUD.Size = new System.Drawing.Size(200, 22);
            this.NoUD.TabIndex = 1;

            this.Gbe.Controls.Add(this.RbFemale);
            this.Gbe.Controls.Add(this.RbMale);
            this.Gbe.Location = new System.Drawing.Point(30, 110);
            this.Gbe.Name = "Gbe";
            this.Gbe.Size = new System.Drawing.Size(200, 70);
            this.Gbe.TabIndex = 2;
            this.Gbe.TabStop = false;
            this.Gbe.Text = "Gender";

            this.RbMale.AutoSize = true;
            this.RbMale.Location = new System.Drawing.Point(20, 30);
            this.RbMale.Name = "RbMale";
            this.RbMale.Size = new System.Drawing.Size(59, 21);
            this.RbMale.TabIndex = 0;
            this.RbMale.TabStop = true;
            this.RbMale.Text = "Male";
            this.RbMale.UseVisualStyleBackColor = true;

            this.RbFemale.AutoSize = true;
            this.RbFemale.Location = new System.Drawing.Point(100, 30);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(75, 21);
            this.RbFemale.TabIndex = 1;
            this.RbFemale.TabStop = true;
            this.RbFemale.Text = "Female";
            this.RbFemale.UseVisualStyleBackColor = true;

            this.Chbe.AutoSize = true;
            this.Chbe.Location = new System.Drawing.Point(30, 200);
            this.Chbe.Name = "Chbe";
            this.Chbe.Size = new System.Drawing.Size(164, 21);
            this.Chbe.TabIndex = 3;
            this.Chbe.Text = "I agree to the terms";
            this.Chbe.UseVisualStyleBackColor = true;

            this.btnShow.Location = new System.Drawing.Point(30, 240);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(200, 35);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Selected";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);

            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 290);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 17);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";

            this.Controls.Add(this.Cbe);
            this.Controls.Add(this.NoUD);
            this.Controls.Add(this.Gbe);
            this.Controls.Add(this.Chbe);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblResult);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox Cbe;
        private System.Windows.Forms.NumericUpDown NoUD;
        private System.Windows.Forms.GroupBox Gbe;
        private System.Windows.Forms.RadioButton RbMale;
        private System.Windows.Forms.RadioButton RbFemale;
        private System.Windows.Forms.CheckBox Chbe;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblResult;
    }
}
