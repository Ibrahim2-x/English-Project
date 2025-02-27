using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;


namespace English_Project
{
    public partial class Vocabulary : Form
    {
        public Vocabulary()
        {
            InitializeComponent();
            this.CancelButton = btnBack;
        }
        private void CenterButton(System.Windows.Forms.Button SelectedButton, int Top)
        {
            SelectedButton.TextAlign = ContentAlignment.MiddleCenter;
            SelectedButton.Left = (this.ClientSize.Width - SelectedButton.Width) / 2;
            SelectedButton.Top = Top;
        }
        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void Vocabulary_Load(object sender, System.EventArgs e)
        {
            CenterButton(btnBack, 370);
            lblNoVocabs.Text = cbVocabs.Items.Count.ToString();
            progressBar2.Maximum = cbVocabs.Items.Count + cbToLearn.Items.Count + cbLearned.Items.Count;
            progressBar1.Maximum = cbVocabs.Items.Count + cbToLearn.Items.Count + cbLearned.Items.Count;

        }

        private int RandomIndexInComboBox(int From, int To)
        {
            Random rnd = new Random();
            return rnd.Next(From, To);
        }

        private void btGenerateRandomVocab_Click(object sender, EventArgs e)
        {
            if (cbVocabs.Items.Count == 0)
            {
                MessageBox.Show("Vocabulary list is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbVocabs.Text = "";
                return;
            }

            int CurrentIndex = RandomIndexInComboBox(0, cbVocabs.Items.Count);
            string CurrenttItem = cbVocabs.Items[CurrentIndex].ToString();
            cbVocabs.SelectedItem = CurrenttItem;

        }
        private void btGenerateRandomVocabRed_Click(object sender, EventArgs e)
        {
            if (cbToLearn.Items.Count == 0)
            {
                MessageBox.Show("\"To Learn\" list is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbToLearn.Text = "";
                return;
            }

            int CurrentIndex = RandomIndexInComboBox(0, cbToLearn.Items.Count);
            string CurrenttItem = cbToLearn.Items[CurrentIndex].ToString();
            cbToLearn.SelectedItem = CurrenttItem;
        }
        private void btGenerateRandomVocabGreen_Click(object sender, EventArgs e)
        {
            if (cbLearned.Items.Count == 0)
            {
                MessageBox.Show("\"Learned\" list is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLearned.Text = "";
                return;
            }

            int CurrentIndex = RandomIndexInComboBox(0, cbLearned.Items.Count);
            string CurrenttItem = cbLearned.Items[CurrentIndex].ToString();
            cbLearned.SelectedItem = CurrenttItem;
        }

        private void btnAddToLearn_Click(object sender, EventArgs e)
        {
            int TotalSize = cbVocabs.Items.Count + cbToLearn.Items.Count;
            int _ItemSize = cbVocabs.Items.Count;
            lblNoVocabs.Text = (_ItemSize).ToString();
            lblNoToLearn.Text = (TotalSize - _ItemSize).ToString();
            if ((cbVocabs.SelectedItem == null))
            {
                MessageBox.Show("Select or generate a vocab to add to \"To Learn\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"Vocabulry  >>  To Learn \n\nAdd \"{cbVocabs.SelectedItem.ToString()}\" ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblNoVocabs.Text = (_ItemSize - 1).ToString();
                lblNoToLearn.Text = (TotalSize - _ItemSize + 1).ToString();
                cbToLearn.Items.Add(cbVocabs.SelectedItem);
                cbToLearn.SelectedItem = cbVocabs.SelectedItem;
                cbVocabs.Items.Remove(cbVocabs.SelectedItem);
                cbVocabs.SelectedIndex = cbVocabs.Items.Count - 1;
                if (cbVocabs.Items.Count == 0)
                {
                    cbVocabs.Text = "";
                    MessageBox.Show("You've added all vocabs to \"To Learn\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                return;
            }


        }



        private void cbVocabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVocabs.Items.Count == 0)
            {
                MessageBox.Show("You've added all vocabs to \"To Learn\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbVocabs.Text = "";
                btGenerateRandomVocabYellow.Enabled = false;
                return;
            }
        }

        private void btnLearned_Click(object sender, EventArgs e)
        {


            if ((cbToLearn.SelectedItem == null))
            {
                MessageBox.Show("Select a word from \"To Learn\" to add to \"Learned\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((cbVocabs.SelectedItem == null) && (cbToLearn.SelectedItem == null))
            {
                MessageBox.Show("Your list is empty, select or generate a vocab", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"To Learn  >>  Learned \n\n\" Add \"{cbToLearn.SelectedItem.ToString()}\"?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (cbToLearn.SelectedItem != null)
                {
                    int TotalSize = cbLearned.Items.Count + cbToLearn.Items.Count;
                    int _ItemSize = cbToLearn.Items.Count;
                    lblNoToLearn.Text = (_ItemSize).ToString();
                    lblNoLearned.Text = (TotalSize - _ItemSize).ToString();
                    int CurrentIndex = cbToLearn.Items.Count - 1;
                    lblNoToLearn.Text = (_ItemSize - 1).ToString();
                    lblNoLearned.Text = (TotalSize - _ItemSize + 1).ToString();
                    cbLearned.Items.Add(cbToLearn.SelectedItem);
                    cbLearned.Text = cbToLearn.SelectedItem.ToString();
                    cbToLearn.Items.Remove(cbToLearn.SelectedItem);
                    cbToLearn.SelectedIndex = cbToLearn.Items.Count - 1;
                    progressBar2.Maximum = cbVocabs.Items.Count + cbToLearn.Items.Count + cbLearned.Items.Count;
                    progressBar1.Maximum = cbVocabs.Items.Count + cbToLearn.Items.Count + cbLearned.Items.Count;
                    SoundPlayer player = new SoundPlayer("C:\\Users\\haruX\\Desktop\\Personal\\Blast.wav");
                    player.Play();
                    if (progressBar2.Value < progressBar2.Maximum)
                    {

                        Thread.Sleep(200);
                        progressBar2.Value += 1;
                        progressBar1.Value -= 1;
                        lblProgressBar2.Text = (Math.Round(((float)progressBar2.Value / progressBar2.Maximum) * 100)) + "%";
                        lblProgressBar1.Text = (Math.Round(((float)progressBar1.Value / progressBar1.Maximum) * 100)) + "%";
                        progressBar2.Refresh();

                    }
                    if (lblProgressBar2.Text == "100%")
                    {
                        pbLeft.Visible = false;
                        notifyIcon1.Icon = SystemIcons.Shield;
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.BalloonTipTitle = "Congrats";
                        notifyIcon1.BalloonTipText = "You've learned all the vocabs!";
                        notifyIcon1.ShowBalloonTip(1000);
                    }

                    if (cbToLearn.Items.Count == 0)
                    {
                        cbToLearn.Text = "";
                        MessageBox.Show("You've added all vocabs in \" To Learn\" to \"Learned\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                }

            }
            else
            {

                return;
            }
        }


        private void btnRemoveFromToLearn_Click(object sender, EventArgs e)
        {
            int TotalSize = cbVocabs.Items.Count + cbToLearn.Items.Count;
            int _ItemSize = cbVocabs.Items.Count;
            lblNoVocabs.Text = (_ItemSize).ToString();
            lblNoToLearn.Text = (TotalSize - _ItemSize).ToString();
            int CurrentIndex = cbToLearn.Items.Count - 1;
            if (cbToLearn.SelectedItem == null)
            {
                MessageBox.Show("Select a vocab to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"Vocabulary  <<  To Learn \n\nRemove \"{cbToLearn.SelectedItem.ToString()}\"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                lblNoVocabs.Text = (_ItemSize + 1).ToString();
                lblNoToLearn.Text = (TotalSize - _ItemSize - 1).ToString();

                cbVocabs.Items.Add(cbToLearn.SelectedItem);
                cbVocabs.SelectedItem = cbToLearn.SelectedItem;
                cbToLearn.Items.Remove(cbToLearn.SelectedItem);

                if (cbToLearn.Items.Count == 0)
                {
                    cbToLearn.Text = "";
                    MessageBox.Show("You've removed all vocabs from \"To Learn\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {

                return;
            }
        }

        private void btnRemoveFromLearned_Click(object sender, EventArgs e)
        {
            int TotalSize = cbToLearn.Items.Count + cbLearned.Items.Count;
            int _ItemSize = cbToLearn.Items.Count;
            lblNoToLearn.Text = (_ItemSize).ToString();
            lblNoLearned.Text = (TotalSize - _ItemSize).ToString();
            int CurrentIndex = cbLearned.Items.Count - 1;
            if (cbLearned.SelectedItem == null)
            {
                MessageBox.Show("Select a vocab to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"To Learn  <<  Learned\n\nRemove \"{cbLearned.SelectedItem.ToString()}\"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                lblNoToLearn.Text = (_ItemSize + 1).ToString();
                lblNoLearned.Text = (TotalSize - _ItemSize - 1).ToString();
                if (cbLearned.SelectedItem == null)
                {
                    MessageBox.Show("Select a vocab to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cbToLearn.Items.Add(cbLearned.SelectedItem);
                cbToLearn.SelectedItem = cbLearned.SelectedItem;
                cbLearned.Items.Remove(cbLearned.SelectedItem);
                progressBar2.Maximum = cbVocabs.Items.Count + cbToLearn.Items.Count + cbLearned.Items.Count;
                progressBar1.Maximum = cbVocabs.Items.Count + cbToLearn.Items.Count + cbLearned.Items.Count;

                if (progressBar2.Value <= progressBar2.Maximum)
                {
                    Thread.Sleep(100);
                    progressBar2.Value -= 1;
                    progressBar1.Value += 1;
                    lblProgressBar2.Text = (Math.Round(((float)progressBar2.Value / progressBar2.Maximum) * 100)) + "%";
                    lblProgressBar1.Text = (Math.Round(((float)progressBar1.Value / progressBar1.Maximum) * 100)) + "%";
                    progressBar2.Refresh();
                }
                if (cbLearned.Items.Count == 0)
                {
                    cbLearned.Text = "";
                    MessageBox.Show("You've removed all vocabs from \"Learned\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {

                return;
            }
        }

        private void cbVocabs_KeyDown(object sender, KeyEventArgs e)
        {
            cbVocabs.DropDownStyle = ComboBoxStyle.DropDownList;

            if (e.KeyCode == Keys.Down)
            {
                if (cbVocabs.SelectedIndex < cbVocabs.Items.Count - 1)
                {
                    cbVocabs.SelectedIndex += 1;  // Move to next item
                }
                else
                {
                    // Loop back to the first item if at the last item
                    cbVocabs.SelectedIndex = 0;
                }

                e.Handled = true;  // Prevent default handling
            }

            // Handle Up arrow key
            else if (e.KeyCode == Keys.Up)
            {
                if (cbVocabs.SelectedIndex > 0)
                {
                    cbVocabs.SelectedIndex -= 1;  // Move to previous item
                }
                else
                {
                    // Loop back to the last item if at the first item
                    cbVocabs.SelectedIndex = cbVocabs.Items.Count - 1;
                }
            }
            e.Handled = true;

        }
        private void cbToLearn_KeyDown(object sender, KeyEventArgs e)
        {
            cbToLearn.DropDownStyle = ComboBoxStyle.DropDownList;

            if (e.KeyCode == Keys.Down)
            {
                if (cbToLearn.SelectedIndex < cbToLearn.Items.Count - 1)
                {
                    cbToLearn.SelectedIndex += 1;  // Move to next item
                }
                else
                {
                    // Loop back to the first item if at the last item
                    cbToLearn.SelectedIndex = 0;
                }

                e.Handled = true;  // Prevent default handling
            }

            // Handle Up arrow key
            else if (e.KeyCode == Keys.Up)
            {
                if (cbToLearn.SelectedIndex > 0)
                {
                    cbToLearn.SelectedIndex -= 1;  // Move to previous item
                }
                else
                {
                    // Loop back to the last item if at the first item
                    cbToLearn.SelectedIndex = cbToLearn.Items.Count - 1;
                }
            }
            e.Handled = true;

        }
        private void cbLearned_KeyDown(object sender, KeyEventArgs e)
        {
            cbLearned.DropDownStyle = ComboBoxStyle.DropDownList;

            if (e.KeyCode == Keys.Down)
            {
                if (cbLearned.SelectedIndex < cbLearned.Items.Count - 1)
                {
                    cbLearned.SelectedIndex += 1;  // Move to next item
                }
                else
                {
                    cbLearned.SelectedIndex = 0;
                }

                e.Handled = true;  // Prevent default handling
            }

            // Handle Up arrow key
            else if (e.KeyCode == Keys.Up)
            {
                if (cbLearned.SelectedIndex > 0)
                {
                    cbLearned.SelectedIndex -= 1;  // Move to previous item
                }
                else
                {
                    cbLearned.SelectedIndex = cbLearned.Items.Count - 1;
                }
            }
            e.Handled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((cbVocabs.SelectedItem == null))
            {
                MessageBox.Show("Select a word from \"Vocabulary\" to add to \"Learned\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"Vocabulary  >>  Learned \n\n\" Add \"{cbVocabs.SelectedItem.ToString()}\"?", "Add", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int TotalSizee = cbLearned.Items.Count + cbVocabs.Items.Count;
                int _ItemSizee = cbVocabs.Items.Count;
                lblNoLearned.Text = (_ItemSizee).ToString();
                lblNoVocabs.Text = (TotalSizee - _ItemSizee).ToString();
                int CurrentIndexx = cbVocabs.Items.Count - 1;
                lblNoVocabs.Text = (_ItemSizee - 1).ToString();
                lblNoLearned.Text = (TotalSizee - _ItemSizee + 1).ToString();
                cbLearned.Items.Add(cbVocabs.SelectedItem);
                cbLearned.Text = cbVocabs.SelectedItem.ToString();
                cbVocabs.Items.Remove(cbVocabs.SelectedItem);
                cbVocabs.SelectedIndex = cbVocabs.Items.Count - 1;
                progressBar2.Maximum = cbVocabs.Items.Count + cbToLearn.Items.Count + cbLearned.Items.Count;
                progressBar1.Maximum = cbVocabs.Items.Count + cbToLearn.Items.Count + cbLearned.Items.Count;

                SoundPlayer player = new SoundPlayer("C:\\Users\\haruX\\Desktop\\Personal\\Blast.wav");
                player.Play();

                if (progressBar2.Value <= progressBar2.Maximum)
                {

                    Thread.Sleep(200);
                    progressBar2.Value += 1;
                    progressBar1.Value -= 1;
                    lblProgressBar2.Text = (Math.Round(((float)progressBar2.Value / progressBar2.Maximum) * 100)) + "%";
                    lblProgressBar1.Text = (Math.Round(((float)progressBar1.Value / progressBar1.Maximum) * 100)) + "%";
                    progressBar2.Refresh();
                }
                if (lblProgressBar2.Text == "100%")
                {
                    pbLeft.Visible = false;
                    notifyIcon1.Icon = SystemIcons.Shield;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipTitle = "Congrats";
                    notifyIcon1.BalloonTipText = "You've learned all the vocabs!";
                    notifyIcon1.ShowBalloonTip(1000);
                }
                if (cbVocabs.Items.Count == 0)
                {
                    cbVocabs.Text = "";
                    MessageBox.Show("No vocabs in the list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {

                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbVocabs.SelectedItem == null)
            {
                MessageBox.Show("Select a vocab to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"Delete \"{cbVocabs.SelectedItem.ToString()}\" from vocabulary list?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblNoVocabs.Text = (cbVocabs.Items.Count - 1).ToString();
                cbVocabs.Items.Remove(cbVocabs.SelectedItem);
                cbVocabs.SelectedIndex = cbVocabs.Items.Count - 1;
                progressBar2.Maximum = cbVocabs.Items.Count + cbToLearn.Items.Count + cbLearned.Items.Count;
                progressBar1.Maximum = cbVocabs.Items.Count + cbToLearn.Items.Count + cbLearned.Items.Count;

                if (progressBar2.Value <= progressBar2.Maximum)
                {
                    Thread.Sleep(100);
                    progressBar1.Value -= 1;
                    lblProgressBar2.Text = (Math.Round(((float)progressBar2.Value / progressBar2.Maximum) * 100)) + "%";
                    lblProgressBar1.Text = (Math.Round(((float)progressBar1.Value / progressBar1.Maximum) * 100)) + "%";
                    progressBar2.Refresh();
                }
                if (cbVocabs.Items.Count == 0)
                {
                    cbVocabs.Text = "";
                    MessageBox.Show("You've removed all vocabs from \"Vocabulary\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {

                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Shield;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Congrats";
            notifyIcon1.BalloonTipText = "You've learned all the vocabs!";
            notifyIcon1.ShowBalloonTip(1000);

        }

    }
}