namespace Formapp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    public void btnAdd_click(object sender, EventArgs e)
    {
        Text3.Text = Convert.ToString(Convert.ToInt32(Text1.Text) + Convert.ToInt32(Text2.Text));

    }

    public void btnSub_click(object sender, EventArgs e)
    {
        Text3.Text = Convert.ToString(Convert.ToInt32(Text1.Text) - Convert.ToInt32(Text2.Text));

    }

    public void btnMul_click(object sender, EventArgs e)
    {
        Text3.Text = Convert.ToString(Convert.ToInt32(Text1.Text) * Convert.ToInt32(Text2.Text));

    }
    
    public void btnDiv_click(object sender, EventArgs e)
    {
        Text3.Text = Convert.ToString(Convert.ToInt32(Text1.Text) / Convert.ToInt32(Text2.Text));
        
    }

}
