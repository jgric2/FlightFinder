namespace Flight_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var flight = FlightFinder.FindFlightInstances("flight");
            var lightf = FlightFinder.FindFlightInstances("lightf");
            var flightflight = FlightFinder.FindFlightInstances("flightflight");
            var fflliigghhtt = FlightFinder.FindFlightInstances("fflliigghhtt");
            var lightfabc = FlightFinder.FindFlightInstances("lightfabc");
            var abc = FlightFinder.FindFlightInstances("abc");

            listView1.SuspendLayout();
            listView1.Items.Add(GenerateLvItem("flight", flight));
            listView1.Items.Add(GenerateLvItem("lightf", lightf));
            listView1.Items.Add(GenerateLvItem("flightflight", flightflight));
            listView1.Items.Add(GenerateLvItem("fflliigghhtt", fflliigghhtt));
            listView1.Items.Add(GenerateLvItem("lightfabc", lightfabc));
            listView1.Items.Add(GenerateLvItem("abc", abc));
            listView1.ResumeLayout();
        }

        private ListViewItem GenerateLvItem(string text, int count)
        {
            ListViewItem lvitem = new ListViewItem(text);
            lvitem.SubItems.Add(count.ToString());
            return lvitem;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;

            var count = FlightFinder.FindFlightInstances(textBox1.Text);
            listView1.Items.Add(GenerateLvItem(textBox1.Text, count));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
