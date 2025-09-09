namespace apic_;

public partial class Form1 : Form
{
    private List<Post> _posts;
    private readonly Apiservice _apiservice;
    public Form1()
    {
        _apiservice = new Apiservice("https://jsonplaceholder.typicode.com/");
        InitializeComponent();
        LoadDataAsync();
    }
    private async Task LoadDataAsync()
    {
        _posts = await _apiservice.GetAllAsync<Post>("posts");
        dgView.DataSource = _posts;
    }
    public async void btnRead_Click(object sender, EventArgs e)
    {
        Post _post = await _apiservice.GetAsync<Post>("posts", Int32.Parse(txtid.Text));
        txtuserid.Text = Convert.ToString(_post.UserId);
        txttitle.Text = _post.Title;
        txtbody.Text = _post.Body;

    }
    public async void btnAdd_Click(object sender, EventArgs e)
    {
        Post post = new Post();
        post.Id = int.Parse(txtid.Text);
        post.UserId = int.Parse(txtuserid.Text);
        post.Title = txttitle.Text;
        post.Body = txtbody.Text;
        string StatusCode = await _apiservice.CreateAsync("posts", post);
        if (StatusCode == "201")
            MessageBox.Show("Created sucessfully " + StatusCode, "Api", MessageBoxButtons.OK, MessageBoxIcon.Information);
        else
            MessageBox.Show("Not created some error " + StatusCode, "Api", MessageBoxButtons.OK, MessageBoxIcon.Error);

    }

    public async void btnUpdate_Click(object sender, EventArgs e)
    {
        Post post = new Post();
        post.Id = int.Parse(txtid.Text);
        post.UserId = int.Parse(txtuserid.Text);
        post.Title = txttitle.Text;
        post.Body = txtbody.Text;
        string StatusCode = await _apiservice.UpdateAsync("posts", Int32.Parse(txtid.Text), post);
        if (StatusCode == "200")
            MessageBox.Show("Updated sucessfully " + StatusCode, "Api", MessageBoxButtons.OK, MessageBoxIcon.Information);
        else
            MessageBox.Show("Not Updated some error " + StatusCode, "Api", MessageBoxButtons.OK, MessageBoxIcon.Error);

    }

    public async void btnDelete_Click(object sender, EventArgs e)
    {
        Post post = new Post();
        string StatusCode = await _apiservice.DeleteAsync<Post>("posts", Int32.Parse(txtid.Text));
        if (StatusCode == "200")
            MessageBox.Show("Deleted sucessfully " + StatusCode, "Api", MessageBoxButtons.OK, MessageBoxIcon.Information);
        else
            MessageBox.Show("Not Deleted some error " + StatusCode, "Api", MessageBoxButtons.OK, MessageBoxIcon.Error);

    }

}
