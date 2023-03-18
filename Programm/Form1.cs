using System.Runtime.Intrinsics.X86;

namespace Programm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void MainButton_Click(object sender, EventArgs e)
        {

            DataTextBox.Text = null;
            int matrixSize = 0;

            try
            {
                matrixSize = int.Parse(MatrixSize.Text);
            }
            catch
            {
                DataTextBox.Text = "ENTER THE COORECT VALUE";
            }
            finally
            {

                int[,] matrix = new int[matrixSize, matrixSize];

                for (int i = 0; i < matrixSize; i++)
                {
                    for (int j = 0; j < matrixSize; j++)
                    {

                        matrix[i, j] = (i % 2 == j % 2) ? 1 : 0;

                        DataTextBox.Text = DataTextBox.Text + matrix[i, j] + "\t";
                    }
                    DataTextBox.Text = DataTextBox.Text + System.Environment.NewLine;
                }

            }



















        }
    }
}