namespace formapp1;

partial class Form1
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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        t1 = new TextBox();
        t1.Location = new System.Drawing.Point(100, 100);
        t1.Size = new System.Drawing.Size(200, 0);
        // t1.Name= "t1";
        t1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t1_keypress);
        t1.TextChanged += new System.EventHandler(this.t1_textchanged);
        t1.TabIndex = 2;
        this.Controls.Add(t1);

        t2 = new TextBox();
        t2.Location = new System.Drawing.Point(100, 150);
        t2.Size = new System.Drawing.Size(200, 0);
        // t2.Name= "t2";
        t2.Enabled = false;
        this.Controls.Add(t2);

        t3 = new TextBox();
        t3.Location = new System.Drawing.Point(100, 200);
        t3.Size = new System.Drawing.Size(200, 0);
        t3.Name = "t3";
        t3.GotFocus += new System.EventHandler(this.t3_onfocus);
        t3.Leave += new System.EventHandler(this.t3_onleave);
        t3.TabIndex = 0;
        t3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t3_keydown);
        this.Controls.Add(t3);

        t4 = new TextBox();
        t4.Location = new System.Drawing.Point(100, 250);
        t4.Size = new System.Drawing.Size(200, 0);
        t4.Name = "t4";
        t4.MouseEnter += new System.EventHandler(this.t4_mouseenter);
        t4.MouseLeave += new System.EventHandler(this.t4_mouseleave);
        t4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.t4_keyup);
        t4.MouseEnter += new System.EventHandler(this.t4_mouseenter);
        t4.MouseLeave += new System.EventHandler(this.t4_mouseleave);
        t4.KeyUp += new System.Windows.Forms.KeyEventHandler (this.t4_keyup);
        this.Controls.Add(t4);

        p1 = new PictureBox();
        p1.Location = new System.Point(100,350);
        p1.Size= new Systembrawing.Size(400,400);
        p1.Name= "p1";
        p1.BackColor= System.Drawing.Color.White;
        p1.MouseUp+=new System.Windows.Forms.MouseEventHandler(this.p1_mouseup);
        p1.MouseDown+=new System.Windows.Forms.MouseEventHandler(this.p1_mousedown);
        this.Controls.Add(p1);
        b1=new Button();
        b1.Location= new System.Drawing.Point(100,300);
        b1.Size = new System.Drawing.Size(200,40);
        b1.Name= "b1";
        b1.Text= "Button";
        b1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.b1_mouseclick);
        b1.Flatstyle= System.Windows.Forms.Flatstyle.System;
        this.Controls.Add(b1);
    }

    private TextBox Text1;
    private TextBox Text2;
    private TextBox Text3;
    private TextBox Text4;
    private PictureBox p1;
    private Button b1;
    

    #endregion
}
