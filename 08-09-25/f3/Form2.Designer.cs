namespace f3
{
    partial class Form2
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
            this.ms = new System.Windows.Forms.MenuStrip();
            this.FileToolsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.sDIToolsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.sDIDialogToolsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mDIToolsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleHorizontalToolsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleVerticalToolsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolsmi = new System.Windows.Forms.ToolStripMenuItem();

            
            this.ms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolsmi,
            this.WindowToolsmi
        });
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(800, 28);
            this.ms.TabIndex = 0;
            this.ms.Text = "menuStrip1";
            this.ms.MdiWindowListItem = this.WindowToolsmi;

            
            this.FileToolsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sDIToolsmi,
            this.sDIDialogToolsmi,
            this.mDIToolsmi
        });
            this.FileToolsmi.Name = "FileToolsmi";
            this.FileToolsmi.Size = new System.Drawing.Size(46, 24);
            this.FileToolsmi.Text = "File";

            this.sDIToolsmi.Name = "sDIToolsmi";
            this.sDIToolsmi.Size = new System.Drawing.Size(187, 26);
            this.sDIToolsmi.Text = "SDI Child";
            this.sDIToolsmi.Click += new System.EventHandler(this.sDIToolsmi_Click);

            this.sDIDialogToolsmi.Name = "sDIDialogToolsmi";
            this.sDIDialogToolsmi.Size = new System.Drawing.Size(187, 26);
            this.sDIDialogToolsmi.Text = "SDI Child Dialog";
            this.sDIDialogToolsmi.Click += new System.EventHandler(this.sDIDialogToolsmi_Click);

            this.mDIToolsmi.Name = "mDIToolsmi";
            this.mDIToolsmi.Size = new System.Drawing.Size(187, 26);
            this.mDIToolsmi.Text = "MDI Child";
            this.mDIToolsmi.Click += new System.EventHandler(this.mDIToolsmi_Click);

            
            this.WindowToolsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TitleHorizontalToolsmi,
            this.TitleVerticalToolsmi,
            this.cascadeToolsmi

    });
            this.WindowToolsmi.Name = "WindowToolsmi";
            this.WindowToolsmi.Size = new System.Drawing.Size(78, 24);
            this.WindowToolsmi.Text = "Window";

            this.TitleHorizontalToolsmi.Name = "TitleHorizontalToolsmi";
            this.TitleHorizontalToolsmi.Size = new System.Drawing.Size(181, 26);
            this.TitleHorizontalToolsmi.Text = "Tile Horizontal";
            this.TitleHorizontalToolsmi.Click += new System.EventHandler(this.TitleHorizontalToolsmi_Click);

            this.TitleVerticalToolsmi.Name = "TitleVerticalToolsmi";
            this.TitleVerticalToolsmi.Size = new System.Drawing.Size(181, 26);
            this.TitleVerticalToolsmi.Text = "Tile Vertical";
            this.TitleVerticalToolsmi.Click += new System.EventHandler(this.TitleVerticalToolsmi_Click);

            this.cascadeToolsmi.Name = "cascadeToolsmi";
            this.cascadeToolsmi.Size = new System.Drawing.Size(181, 26);
            this.cascadeToolsmi.Text = "Cascade";
            this.cascadeToolsmi.Click += new System.EventHandler(this.cascadeToolsmi_Click);

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ms);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms;
            this.Name = "Form2";
            this.Text = "MDI / SDI Demo";


        }


        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem FileToolsmi;
        private System.Windows.Forms.ToolStripMenuItem sDIToolsmi;
        private System.Windows.Forms.ToolStripMenuItem sDIDialogToolsmi;
        private System.Windows.Forms.ToolStripMenuItem mDIToolsmi;
        private System.Windows.Forms.ToolStripMenuItem WindowToolsmi;
        private System.Windows.Forms.ToolStripMenuItem TitleHorizontalToolsmi;
        private System.Windows.Forms.ToolStripMenuItem TitleVerticalToolsmi;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolsmi;


    }
}
