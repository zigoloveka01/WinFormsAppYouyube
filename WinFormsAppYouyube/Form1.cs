namespace WinFormsAppYouyube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] products = { "เหล้า", "เบียร์", "โซดา", "น้ำอัดลม", "กาแฟ", "น้ำเปล่า" };
            checkedListBox1.Items.AddRange(products);
        }

        private void button1_Click(object sender, EventArgs e)
        {//ปุ่ม >>>
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                return;
            }
            // อ่านรายการข้อมูล
            foreach (string iten in checkedListBox1.CheckedItems)
            {
                if (listBox1.FindStringExact(iten) == -1)
                {
                    if (listBox1.FindStringExact(iten) == -1)
                    {
                        listBox1.Items.Add(iten);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                return;
            }
            while(listBox1.SelectedIndex!= -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
