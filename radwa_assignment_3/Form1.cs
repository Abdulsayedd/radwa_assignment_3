namespace radwa_assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog of = new OpenFileDialog();
        string path;
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        string x;
        string[] arr;
        private void eft7elbab()
        {
            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sr = new StreamReader(fs);
            sw = new StreamWriter(fs);
        }
        private void openbtn_Click(object sender, EventArgs e)
        {
            of.ShowDialog();
            path = of.FileName;
            eft7elbab();
        }
        private void insbtn_Click(object sender, EventArgs e)
        {
            x = textBox1.Text + " | " + textBox2.Text + " | " + textBox3.Text + " | " + textBox4.Text +"\r\n";
            sw.Write(x);
            sw.Flush();
            fs.Flush();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            sw.Close();
            fs.Close();
            bigtxt.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            File.WriteAllText(path,string.Empty);
            eft7elbab();

        }
        int m2 = 1;
        private void readonelinebtn_Click(object sender, EventArgs e)
        {
            bigtxt.Text += sr.ReadLine() + "\r\n";
            fs.Seek(m2, SeekOrigin.Begin);
        }
        private void readalllinesbtn_Click(object sender, EventArgs e)
        {
            bigtxt.Text = sr.ReadToEnd();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}