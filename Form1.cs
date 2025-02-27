using System.Drawing;
using System.Windows.Forms;

namespace English_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }




        private void CenterLabel()
        {
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            lblTitle.Top = 10;
        }
        private void CenterButton(Button SelectedButton, int Top)
        {
            SelectedButton.TextAlign = ContentAlignment.MiddleCenter;
            SelectedButton.Left = (this.ClientSize.Width - SelectedButton.Width) / 2;
            SelectedButton.Top = Top;
        }
        private void btnVocabulary_MouseEnter(object sender, System.EventArgs e)
        {
            btnVocabulary.BackColor = Color.Yellow;
        }


        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            Button CurrentButton = (Button)sender;
            CurrentButton.BackColor = Color.White;

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            CenterLabel();
            CenterButton(btnVocabulary, 200);
        }

        private void btnVocabulary_Click(object sender, System.EventArgs e)
        {
            //if (MessageBox.Show("Do you want to open vocabulary section?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            Form vocabulary = new Vocabulary();
            vocabulary.Show();
            //}
            //else
            //{
            //    return;
            //}

        }


    }
}
