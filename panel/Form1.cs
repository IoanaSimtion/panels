namespace panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.RowCount = 3;  // Set the desired number of rows
            tableLayoutPanel1.ColumnCount = 3;  // Set the desired number of columns
            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    Panel panel = new Panel();
                    panel.BackColor = Color.LightGray;
                    panel.Dock = DockStyle.Fill;
                    tableLayoutPanel1.Controls.Add(panel, col, row);
                    panel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}