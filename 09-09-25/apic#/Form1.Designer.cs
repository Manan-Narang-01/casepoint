namespace apic_;

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

    this.StartPosition = FormStartPosition.CenterScreen; 
    this.Size = new System.Drawing.Size(1400, 900);       
    this.Text = "API CRUD Form";

    dgView = new DataGridView();
    dgView.Location = new System.Drawing.Point(100, 100);
    dgView.Size = new System.Drawing.Size(1200, 400);
    this.Controls.Add(dgView);

    btnAdd = new Button();
    btnAdd.Location = new System.Drawing.Point(100, 550);
    btnAdd.Size = new System.Drawing.Size(100, 40);
    btnAdd.Text = "Add";
    btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
    this.Controls.Add(btnAdd);

    btnUpdate = new Button();
    btnUpdate.Location = new System.Drawing.Point(250, 550);
    btnUpdate.Size = new System.Drawing.Size(100, 40);
    btnUpdate.Text = "Update";
    btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
    this.Controls.Add(btnUpdate);

    btnDelete = new Button();
    btnDelete.Location = new System.Drawing.Point(400, 550);
    btnDelete.Size = new System.Drawing.Size(100, 40);
    btnDelete.Text = "Delete";
    btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
    this.Controls.Add(btnDelete);

    btnRead = new Button();
    btnRead.Location = new System.Drawing.Point(550, 550);
    btnRead.Size = new System.Drawing.Size(100, 40);
    btnRead.Text = "Read";
    btnRead.Click += new System.EventHandler(this.btnRead_Click);
    this.Controls.Add(btnRead);

    lblid = new Label();
    lblid.Location = new System.Drawing.Point(100, 650);
    lblid.Text = "Id";
    this.Controls.Add(lblid);

    lbluserid = new Label();
    lbluserid.Location = new System.Drawing.Point(250, 650);
    lbluserid.Text = "User id";
    this.Controls.Add(lbluserid);

    lbltitle = new Label();
    lbltitle.Location = new System.Drawing.Point(400, 650);
    lbltitle.Text = "Title";
    this.Controls.Add(lbltitle);

    lblbody = new Label();
    lblbody.Location = new System.Drawing.Point(550, 650);
    lblbody.Text = "Body";
    this.Controls.Add(lblbody);

    txtid = new TextBox();
    txtid.Location = new System.Drawing.Point(100, 700);
    txtid.Size = new System.Drawing.Size(100, 30);
    this.Controls.Add(txtid);

    txtuserid = new TextBox();
    txtuserid.Location = new System.Drawing.Point(250, 700);
    txtuserid.Size = new System.Drawing.Size(100, 30);
    this.Controls.Add(txtuserid);

    txttitle = new TextBox();
    txttitle.Location = new System.Drawing.Point(400, 700);
    txttitle.Size = new System.Drawing.Size(100, 30);
    this.Controls.Add(txttitle);

    txtbody = new TextBox();
    txtbody.Location = new System.Drawing.Point(550, 700);
    txtbody.Size = new System.Drawing.Size(100, 30);
    this.Controls.Add(txtbody);
}


    private DataGridView dgView;
    private Button btnAdd, btnUpdate, btnDelete, btnRead;
    private TextBox txtid, txtuserid, txttitle, txtbody;
    private Label lblid, lbluserid, lbltitle, lblbody;

    #endregion
}
