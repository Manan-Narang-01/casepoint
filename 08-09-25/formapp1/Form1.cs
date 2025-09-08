namespace formapp1;

public partial class Form1 : Form
{
    private Point startPoint;
    private bool isDrawing = false;
    private Bitmap canvas;
    public Form1()
    {
        InitializeComponent();
        canvas = new Bitmap(p1.Width, p1.Height);

    }
    public void t1_keypress(object sender, KeyPressEventArgs e)
    {
        // t2.Text= e.KeyChar.ToString().ToUpper();
    }
    public void t1_textchanged(object sender, EventArgs e)
    {

        t2.Text = t1.Text.ToUpper();
    }

    public void t3_onfocus(object sender, EventArgs e)
    {
        t3.BackColor = Color.FromArgb(223, 223, 250);
    }


    public void t3_onleave(object sender, EventArgs e)
    {
        t3.BackColor = Color.White;

    }

    public void t3_keydown(object sender, System.Windows.Forms.KeyEventArgs e)
    {
        if (e.Control == true && e.KeyCode == Keys.Home)
        {
            t3.Text = "Clarent Institue";

        }
    }

    public void t4_keyup(object sender, System.Windows.Forms.KeyEventArgs e)
    {

        if (e.Control == true && e.Shift == true && e.KeyCode == Keys.End)
        {
            t4.Text = "Case Point Intern";
        }

    }
    
    public void t4_mouseenter(object sender, EventArgs e)
    {

        t4.BackColor = Color.FromArgb(225, 250, 225);
    }

        public void t4_mouseleave(object sender, EventArgs e)
    {
        t4.BackColor = Color.White;
        
    }




    public void b1_mouseclick(object sender, MouseEventArgs e)
    {

        MessageBox.Show($" Button {e.Button} clicked");

    }
    public void p1_mousedown(object sender, MouseEventArgs e)
    {
        startPoint = e.Location;
        isDrawing = true;
    }
}
