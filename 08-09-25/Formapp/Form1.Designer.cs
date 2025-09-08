namespace Formapp;

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
    { this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            Label1 = new Label();
            Label1.Location = new System.Drawing.Point(100, 100);
            Label1.Size = new System.Drawing.Size(200, 40);
            Label1.Name = "Label1";
            Label1.Text = "First Number :";
            this.Controls.Add(Label1);

            Text1 = new TextBox();
            Text1.Location = new System.Drawing.Point(300, 100);
            Text1.Size = new System.Drawing.Size(200, 30);
            Text1.Name = "Text1";
            this.Controls.Add(Text1);

            Label2 = new Label();
            Label2.Location = new System.Drawing.Point(100, 150);
            Label2.Size = new System.Drawing.Size(200, 40);
            Label2.Name = "Label2";
            Label2.Text = "Second Number :";
            this.Controls.Add(Label2);

            Text2 = new TextBox();
            Text2.Location = new System.Drawing.Point(300, 150);
            Text2.Size = new System.Drawing.Size(200, 30);
            Text2.Name = "Text2";
            this.Controls.Add(Text2);

            Button1 = new Button();
            Button1.Location = new System.Drawing.Point(100, 200);
            Button1.Size = new System.Drawing.Size(200, 40);
            Button1.Name = "Button1";
            Button1.Text = "Add";
            Button1.Click += new System.EventHandler(this.btnAdd_click);
            this.Controls.Add(Button1);

            Button2 = new Button();
            Button2.Location = new System.Drawing.Point(300, 200);
            Button2.Size = new System.Drawing.Size(200, 40);
            Button2.Name = "Button2";
            Button2.Text = "Multiply";
            Button2.Click += new System.EventHandler(this.btnMul_click);
            this.Controls.Add(Button2);

            Button3 = new Button();
            Button3.Location = new System.Drawing.Point(500, 200);
            Button3.Size = new System.Drawing.Size(200, 40);
            Button3.Name = "Button3";
            Button3.Text = "Subtract";
            Button3.Click += new System.EventHandler(this.btnSub_click);
            this.Controls.Add(Button3);

            Button4 = new Button();
            Button4.Location = new System.Drawing.Point(700, 200);
            Button4.Size = new System.Drawing.Size(200, 40);
            Button4.Name = "Button4";
            Button4.Text = "Divide";
            Button4.Click += new System.EventHandler(this.btnDiv_click);
            this.Controls.Add(Button4);

            Label3 = new Label();
            Label3.Location = new System.Drawing.Point(100, 270);
            Label3.Size = new System.Drawing.Size(150, 40);
            Label3.Name = "Label3";
            Label3.Text = "Result :";
            this.Controls.Add(Label3);

            Text3 = new TextBox();
            Text3.Location = new System.Drawing.Point(250, 270);
            Text3.Size = new System.Drawing.Size(200, 30);
            Text3.Name = "Text3";
            this.Controls.Add(Text3);


    }

    private Label Label1;
    private Label Label2;
    private Label Label3;
    
    private TextBox Text1;
    private TextBox Text2;
    private TextBox Text3;
    private TextBox Text4;
    private TextBox Text5;
    private Button Button1;
    private Button Button2;
    private Button Button3;
    private Button Button4;
    

    #endregion
}
