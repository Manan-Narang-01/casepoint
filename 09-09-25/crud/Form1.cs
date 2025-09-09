namespace crud;

public partial class Form1 : Form
{
    private EmployeeService service = new EmployeeService();

    public Form1()
    {
        InitializeComponent();
        LoadEmployee();
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            Employee emp = new Employee(
                EmpId = int.Parse(txtEmpId.Text),
                EmpName = int.txtEmpName.Text,
                EmpSalary = decimal.Parse(txtSalary.Text)
            );
            service.AddEmployee(emp);
            MessageBox.show("inserted!!");
            LoadEmployee();
            clearfields();
        }
        catch (Exception e)
        {
            MessageBox.show("Error!!" + e.Message);

        }

    }

    private void btnUpdated_Click(object sender, EventArgs e)
    {
        try
        {
            Employee emp = new Employee(
                EmpId = int.Parse(txtEmpId.Text),
                EmpName = int.txtEmpName.Text,
                EmpSalary = decimal.Parse(txtSalary.Text)
            );
            bool updated = service.UpdatedEmployee(emp);
            if (updated)
            {
                MessageBox.show("Updated!!");
                LoadEmployee();
                clearfields();
            }
            else
            {
                MessageBox.show("Not Updated!!");

            }
        }
        catch (Exception e)
        {
            MessageBox.show("Error!!" + e.Message);

        }

    }

    private void btnDeleted_Click(object sender, EventArgs e)
    {
        try
        {

            int EmpId = int.Parse(txtEmpId.Text);
            bool updated = service.DeleteEmployee(EmpId);
            if (updated)
            {
                MessageBox.show("Updated!!");
                LoadEmployee();
                clearfields();
            }
            else
            {
                MessageBox.show("Not Updated!!");

            }
        }
        catch (Exception e)
        {
            MessageBox.show("Error!!" + e.Message);

        }

    }
    private void btnView_Click(object sender, EventArgs e)
    {
        LoadEmployee();
    }
    private void LoadEmployee()
    {
        dgvEmployees.DataSource = null;
        dgvEmployees.DataSource = service.GetAllEmpolyees();

    }
    private void clearfields()
    {
        txtEmpId.Clear();
        txtEmpName.Clear();
        txtSalary.Clear();

    }
    
}
