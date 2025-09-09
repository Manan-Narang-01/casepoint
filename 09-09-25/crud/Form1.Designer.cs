namespace crud;

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

        this.lblEmpId = new System.Windows.Forms.Label();
        this.lblEmpName = new System.Windows.Forms.Label();
        this.lblsalary = new System.Windows.Forms.Label();
        this.lblDeptNo = new System.Windows.Forms.Label();
        this.txtEmpId = new System.Windows.Forms.TextBox();
        this.txtEmpName = new System.Windows.Forms.TextBox();
        this.txtSalary = new System.Windows.Forms.TextBox();
        this.txtDeptNo = new System.Windows.Forms.TextBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnView = new System.Windows.Forms.Button();
        this.dgvEmployees = new System.Windows.Forms.DataGridView();
        this.lblEmpId.AutoSize = true;
        this.lblEmpId.Location = new System.Drawing.Point(30, 20);



        this.lblEmpId.Name = "lblEmpId";
        this.lblEmpId.Size = new System.Drawing.Size(55, 17);
        this.lblEmpId.Text = "Emp ID";
        this.lblEmpName.AutoSize = true;
        this.lblEmpName.Location = new System.Drawing.Point(30, 60);
        this.lblEmpName.Name = "1blEmpName";
        this.lblEmpName.Size = new System.Drawing.Size(77, 17);
        this.lblEmpName.Text = "Emp Name";
        this.lblsalary.AutoSize = true;
        this.lblsalary.Location = new System.Drawing.Point(30, 100);
        this.lblsalary.Name = "1blSalary";
        this.lblsalary.Size = new System.Drawing.Size(48, 17);
        this.lblsalary.Text = "Salary";
        this.txtEmpId.Location = new System.Drawing.Point(120, 20);
        this.txtEmpId.Name = "txtEmpId";
        this.txtEmpId.Size = new System.Drawing.Size(150, 22);
        this.txtEmpName.Location = new System.Drawing.Point(120, 60);
        this.txtEmpName.Name = "txtEmpName";
        this.txtEmpName.Size = new System.Drawing.Size(150, 22);
        this.txtSalary.Location = new System.Drawing.Point(120, 100);
        this.txtSalary.Name = "txtSalary";
        this.txtSalary.Size = new System.Drawing.Size(150, 22);
        this.btnAdd.Location = new System.Drawing.Point(300, 20);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(100, 30);
        this.btnAdd.Text = "Add";
        this.btnAdd.UseVisualstyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        this.btnupdate.Location = new System.Drawing.Point(300, 60);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(100, 30);
        this.btnUpdate.Text = "Update";
        this.btnUpdate.UseVisualstyleBackColor = true;
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        this.btnDelete.Location = new System.Drawing.Point(300, 100);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(100, 30);
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualstyleBackColor = true;
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        this.btnView.Location = new System.Drawing.Point(300, 140);
        this.btnView.Name = "btnView";
        this.btnView.Size = new System.Drawing.Size(100, 30);
        this.btnView.Text = "View All";
        this.btnView.UseVisualStyleBackColor = true;
        this.btnView.Click += new System.EventHandler(this.btnView_Click);


        this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvEmployees.Location = new System.Drawing.Point(30, 200);
        this.dgvEmployees.Name = "dgvEmployees";
        this.dgvEmployees.RowHeadersWidth = 51;
        this.dgvEmployees.Size = new System.Drawing.Size(500, 200);
        this.ClientSize = new System.Drawing.Size(600, 450);
        this.Controls.Add(this.dgvEmployees);
        this.Controls.Add(this.btnView);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.txtsalary);
        this.Controls.Add(this.lblEmpName);
        this.Controls.Add(this.lblEmpId);
        this.Name = "FrmEmployee";
        this.Text = "Employee Management";

    }
    #endregion
    
    private DataGridView dgvEmployees;
    private Button btnAdd, btnUpdate, btnDelete, btnView;
    private TextBox txtEmpId, txtSalary, txtEmpName;
    private Label lblEmpName, lblEmpId, lblsalary;
}
