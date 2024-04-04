using Microsoft.VisualBasic;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForms scnd = new SecondForms();
            scnd.Show();
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
          //  button1.Top = button1.Top + 10;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            statusBarHelpLabel.Text = "Кнопка";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            statusBarHelpLabel.Text = "|-+-+-+-+-|";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            foreach (var item in comboBox1.Items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}