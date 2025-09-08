namespace f3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.IsMdiContainer = true;

    }
    private void Form2_Load(object sender, EventArgs e)
    {


    }

    private void sDIToolsmi_Click(object sender, EventArgs e)
    {
        Form1 child = new Form1();
        child.Text = "SDI Child";
        child.Show();

    }


    private void sDIDialogToolsmi_Click(object sender, EventArgs e)
    {

        Form1 child = new Form1();
        child.Text = "SDI Child";
        child.ShowDialog();

    }
    private void mDIToolsmi_Click(object sender, EventArgs e)
    {
        Form1 child = new Form1();
        child.MdiParent = this;
        child.Text = "MDI Child";
        child.Show();


    }

    private void TitleHorizontalToolsmi_Click(object sender, EventArgs e)
    {

        this.LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void TitleVerticalToolsmi_Click(object sender, EventArgs e)
    {

        this.LayoutMdi(MdiLayout.TileVertical);
    }

    private void cascadeToolsmi_Click(object sender, EventArgs e)
    {
        this.LayoutMdi(MdiLayout.Cascade);
    }
    

    
}
