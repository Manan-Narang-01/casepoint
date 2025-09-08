namespace f3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        Cbe.DropDownStyle = ComboBoxStyle.DropDownList;
        RbMale.Checked = true;
        Cbe.Items.Add("Option 1");
        Cbe.Items.Add("Option 2");
        Cbe.Items.Add("Option 3");
        Cbe.SelectedIndex = 0;

    }

    private void btnShow_Click(object sender, EventArgs e)
    {
        string cbt = Cbe.SelectedItem.ToString();
        decimal num = NoUD.Value;
        string gender = RbMale.Checked ? "Male" : RbFemale.Checked ? "Female" : "Not Selected";
        string terms = Chbe.Checked ? "Agreed" : "Not Agreed";
        lblResult.Text = $"ComboBox: {cbt}\n" +
                        $"NumericUpDown: {NoUD}\n" +
                        $"Gender: {gender}\n" +
                        $"Terms: {terms}";

    }
}
