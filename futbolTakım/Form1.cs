namespace futbolTakım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0: 
                    textBox1.Text = "Muslera"; 
                    textBox2.Text = "1290"; 
                    textBox3.Text = "24"; 
                    textBox4.Text="19";
                    listBox1.Items.Add("Muslera"+"\n");
                    listBox1.Items.Add("Nelson" + "\n");
                    listBox1.Items.Add("Davinson" + "\n");
                    listBox1.Items.Add("Abdulkerim" + "\n");
                    listBox1.Items.Add("Barış" + "\n");
                    listBox1.Items.Add("Kerem" + "\n");
                    listBox1.Items.Add("Sara" + "\n");
                    listBox1.Items.Add("İcardi" + "\n");
                    listBox1.Items.Add("Osimhen" + "\n");
                    break;
                case 1:
                    textBox1.Text = "Fred";
                    textBox2.Text = "25";
                    textBox3.Text = "10";
                    textBox4.Text = "1";
                    listBox1.Items.Add("Livakovic" + "\n");
                    listBox1.Items.Add("Osayi Samuel" + "\n");
                    listBox1.Items.Add("Çağlar" + "\n");
                    listBox1.Items.Add("Djıku" + "\n");
                    listBox1.Items.Add("Oosterwolde" + "\n");
                    listBox1.Items.Add("Fred" + "\n");
                    listBox1.Items.Add("Amrabat" + "\n");
                    listBox1.Items.Add("Szymanski" + "\n");
                    listBox1.Items.Add("En Nesyri" + "\n");
                    break;
                case 2:
                    textBox1.Text = "Necip";
                    textBox2.Text = "15";
                    textBox3.Text = "1";
                    textBox4.Text = "0";
                    listBox1.Items.Add("Getson" + "\n");
                    listBox1.Items.Add("Mert" + "\n");
                    listBox1.Items.Add("Semih" + "\n");
                    listBox1.Items.Add("Rafa Silva" + "\n");
                    listBox1.Items.Add("Mustafa" + "\n");
                    listBox1.Items.Add("İmmobile" + "\n");

                    break;

            }

        }
    }




}