namespace English_Project
{
    partial class Vocabulary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vocabulary));
            this.btnBack = new System.Windows.Forms.Button();
            this.btGenerateRandomVocabYellow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbToLearn = new System.Windows.Forms.ComboBox();
            this.cbVocabs = new System.Windows.Forms.ComboBox();
            this.cbLearned = new System.Windows.Forms.ComboBox();
            this.btnAddToLearn = new System.Windows.Forms.Button();
            this.lblNoToLearn = new System.Windows.Forms.Label();
            this.lblNoVocabs = new System.Windows.Forms.Label();
            this.btnLearned = new System.Windows.Forms.Button();
            this.lblNoLearned = new System.Windows.Forms.Label();
            this.btnRemoveFromLearned = new System.Windows.Forms.Button();
            this.btnRemoveFromToLearn = new System.Windows.Forms.Button();
            this.btGenerateRandomVocabRed = new System.Windows.Forms.Button();
            this.btGenerateRandomVocabGreen = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddToLearnDirect = new System.Windows.Forms.Button();
            this.btnRemoveFromVocabulary = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(283, 374);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 40);
            this.btnBack.TabIndex = 10;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btGenerateRandomVocabYellow
            // 
            this.btGenerateRandomVocabYellow.BackColor = System.Drawing.Color.Yellow;
            this.btGenerateRandomVocabYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenerateRandomVocabYellow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btGenerateRandomVocabYellow.Location = new System.Drawing.Point(26, 174);
            this.btGenerateRandomVocabYellow.Name = "btGenerateRandomVocabYellow";
            this.btGenerateRandomVocabYellow.Size = new System.Drawing.Size(165, 50);
            this.btGenerateRandomVocabYellow.TabIndex = 0;
            this.btGenerateRandomVocabYellow.Text = "Generate Random Vocab";
            this.btGenerateRandomVocabYellow.UseVisualStyleBackColor = false;
            this.btGenerateRandomVocabYellow.Click += new System.EventHandler(this.btGenerateRandomVocab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vocabulary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Learned";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "To Learn";
            // 
            // cbToLearn
            // 
            this.cbToLearn.FormattingEnabled = true;
            this.cbToLearn.Location = new System.Drawing.Point(281, 132);
            this.cbToLearn.Name = "cbToLearn";
            this.cbToLearn.Size = new System.Drawing.Size(165, 21);
            this.cbToLearn.TabIndex = 3;
            this.cbToLearn.TabStop = false;
            this.cbToLearn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbToLearn_KeyDown);
            // 
            // cbVocabs
            // 
            this.cbVocabs.FormattingEnabled = true;
            this.cbVocabs.Items.AddRange(new object[] {
            "Hello",
            "Bye",
            "Green",
            "White",
            "Black",
            "Red",
            "Yellow"});
            this.cbVocabs.Location = new System.Drawing.Point(26, 132);
            this.cbVocabs.Name = "cbVocabs";
            this.cbVocabs.Size = new System.Drawing.Size(165, 21);
            this.cbVocabs.TabIndex = 1;
            this.cbVocabs.TabStop = false;
            this.cbVocabs.SelectedIndexChanged += new System.EventHandler(this.cbVocabs_SelectedIndexChanged);
            this.cbVocabs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbVocabs_KeyDown);
            // 
            // cbLearned
            // 
            this.cbLearned.FormattingEnabled = true;
            this.cbLearned.Location = new System.Drawing.Point(536, 132);
            this.cbLearned.Name = "cbLearned";
            this.cbLearned.Size = new System.Drawing.Size(165, 21);
            this.cbLearned.TabIndex = 7;
            this.cbLearned.TabStop = false;
            this.cbLearned.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbLearned_KeyDown);
            // 
            // btnAddToLearn
            // 
            this.btnAddToLearn.BackColor = System.Drawing.Color.Red;
            this.btnAddToLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToLearn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddToLearn.Location = new System.Drawing.Point(197, 106);
            this.btnAddToLearn.Name = "btnAddToLearn";
            this.btnAddToLearn.Size = new System.Drawing.Size(78, 38);
            this.btnAddToLearn.TabIndex = 1;
            this.btnAddToLearn.Text = "Add to    To Learn";
            this.btnAddToLearn.UseVisualStyleBackColor = false;
            this.btnAddToLearn.Click += new System.EventHandler(this.btnAddToLearn_Click);
            // 
            // lblNoToLearn
            // 
            this.lblNoToLearn.AutoSize = true;
            this.lblNoToLearn.BackColor = System.Drawing.Color.Red;
            this.lblNoToLearn.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblNoToLearn.ForeColor = System.Drawing.Color.Black;
            this.lblNoToLearn.Location = new System.Drawing.Point(352, 24);
            this.lblNoToLearn.Name = "lblNoToLearn";
            this.lblNoToLearn.Size = new System.Drawing.Size(23, 24);
            this.lblNoToLearn.TabIndex = 10;
            this.lblNoToLearn.Text = "0";
            // 
            // lblNoVocabs
            // 
            this.lblNoVocabs.AutoSize = true;
            this.lblNoVocabs.BackColor = System.Drawing.Color.Yellow;
            this.lblNoVocabs.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblNoVocabs.ForeColor = System.Drawing.Color.Black;
            this.lblNoVocabs.Location = new System.Drawing.Point(94, 24);
            this.lblNoVocabs.Name = "lblNoVocabs";
            this.lblNoVocabs.Size = new System.Drawing.Size(23, 24);
            this.lblNoVocabs.TabIndex = 11;
            this.lblNoVocabs.Text = "0";
            // 
            // btnLearned
            // 
            this.btnLearned.BackColor = System.Drawing.Color.Lime;
            this.btnLearned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearned.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnLearned.Location = new System.Drawing.Point(452, 122);
            this.btnLearned.Name = "btnLearned";
            this.btnLearned.Size = new System.Drawing.Size(78, 38);
            this.btnLearned.TabIndex = 4;
            this.btnLearned.Text = "Add to Learned";
            this.btnLearned.UseVisualStyleBackColor = false;
            this.btnLearned.Click += new System.EventHandler(this.btnLearned_Click);
            // 
            // lblNoLearned
            // 
            this.lblNoLearned.AutoSize = true;
            this.lblNoLearned.BackColor = System.Drawing.Color.Lime;
            this.lblNoLearned.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblNoLearned.ForeColor = System.Drawing.Color.Black;
            this.lblNoLearned.Location = new System.Drawing.Point(610, 24);
            this.lblNoLearned.Name = "lblNoLearned";
            this.lblNoLearned.Size = new System.Drawing.Size(23, 24);
            this.lblNoLearned.TabIndex = 13;
            this.lblNoLearned.Text = "0";
            // 
            // btnRemoveFromLearned
            // 
            this.btnRemoveFromLearned.Location = new System.Drawing.Point(536, 230);
            this.btnRemoveFromLearned.Name = "btnRemoveFromLearned";
            this.btnRemoveFromLearned.Size = new System.Drawing.Size(165, 24);
            this.btnRemoveFromLearned.TabIndex = 6;
            this.btnRemoveFromLearned.TabStop = false;
            this.btnRemoveFromLearned.Text = "Remove from Learned";
            this.btnRemoveFromLearned.UseVisualStyleBackColor = true;
            this.btnRemoveFromLearned.Click += new System.EventHandler(this.btnRemoveFromLearned_Click);
            // 
            // btnRemoveFromToLearn
            // 
            this.btnRemoveFromToLearn.Location = new System.Drawing.Point(283, 230);
            this.btnRemoveFromToLearn.Name = "btnRemoveFromToLearn";
            this.btnRemoveFromToLearn.Size = new System.Drawing.Size(163, 24);
            this.btnRemoveFromToLearn.TabIndex = 7;
            this.btnRemoveFromToLearn.TabStop = false;
            this.btnRemoveFromToLearn.Text = "Remove from To Learn";
            this.btnRemoveFromToLearn.UseVisualStyleBackColor = true;
            this.btnRemoveFromToLearn.Click += new System.EventHandler(this.btnRemoveFromToLearn_Click);
            // 
            // btGenerateRandomVocabRed
            // 
            this.btGenerateRandomVocabRed.BackColor = System.Drawing.Color.Red;
            this.btGenerateRandomVocabRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenerateRandomVocabRed.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btGenerateRandomVocabRed.Location = new System.Drawing.Point(281, 174);
            this.btGenerateRandomVocabRed.Name = "btGenerateRandomVocabRed";
            this.btGenerateRandomVocabRed.Size = new System.Drawing.Size(165, 50);
            this.btGenerateRandomVocabRed.TabIndex = 3;
            this.btGenerateRandomVocabRed.Text = "Generate Random Vocab";
            this.btGenerateRandomVocabRed.UseVisualStyleBackColor = false;
            this.btGenerateRandomVocabRed.Click += new System.EventHandler(this.btGenerateRandomVocabRed_Click);
            // 
            // btGenerateRandomVocabGreen
            // 
            this.btGenerateRandomVocabGreen.BackColor = System.Drawing.Color.Lime;
            this.btGenerateRandomVocabGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenerateRandomVocabGreen.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btGenerateRandomVocabGreen.Location = new System.Drawing.Point(536, 173);
            this.btGenerateRandomVocabGreen.Name = "btGenerateRandomVocabGreen";
            this.btGenerateRandomVocabGreen.Size = new System.Drawing.Size(165, 50);
            this.btGenerateRandomVocabGreen.TabIndex = 5;
            this.btGenerateRandomVocabGreen.Text = "Generate Random Vocab";
            this.btGenerateRandomVocabGreen.UseVisualStyleBackColor = false;
            this.btGenerateRandomVocabGreen.Click += new System.EventHandler(this.btGenerateRandomVocabGreen_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(263, 323);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar2.Size = new System.Drawing.Size(211, 23);
            this.progressBar2.TabIndex = 15;
            // 
            // lblProgressBar2
            // 
            this.lblProgressBar2.AutoSize = true;
            this.lblProgressBar2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBar2.Location = new System.Drawing.Point(168, 384);
            this.lblProgressBar2.Name = "lblProgressBar2";
            this.lblProgressBar2.Size = new System.Drawing.Size(33, 19);
            this.lblProgressBar2.TabIndex = 16;
            this.lblProgressBar2.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(263, 345);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(211, 23);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Value = 100;
            // 
            // lblProgressBar1
            // 
            this.lblProgressBar1.AutoSize = true;
            this.lblProgressBar1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBar1.Location = new System.Drawing.Point(503, 384);
            this.lblProgressBar1.Name = "lblProgressBar1";
            this.lblProgressBar1.Size = new System.Drawing.Size(49, 19);
            this.lblProgressBar1.TabIndex = 20;
            this.lblProgressBar1.Text = "100%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "VS";
            // 
            // btnAddToLearnDirect
            // 
            this.btnAddToLearnDirect.BackColor = System.Drawing.Color.Lime;
            this.btnAddToLearnDirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToLearnDirect.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddToLearnDirect.Location = new System.Drawing.Point(197, 140);
            this.btnAddToLearnDirect.Name = "btnAddToLearnDirect";
            this.btnAddToLearnDirect.Size = new System.Drawing.Size(78, 38);
            this.btnAddToLearnDirect.TabIndex = 2;
            this.btnAddToLearnDirect.Text = "Add to Learned";
            this.btnAddToLearnDirect.UseVisualStyleBackColor = false;
            this.btnAddToLearnDirect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveFromVocabulary
            // 
            this.btnRemoveFromVocabulary.Location = new System.Drawing.Point(26, 230);
            this.btnRemoveFromVocabulary.Name = "btnRemoveFromVocabulary";
            this.btnRemoveFromVocabulary.Size = new System.Drawing.Size(165, 24);
            this.btnRemoveFromVocabulary.TabIndex = 8;
            this.btnRemoveFromVocabulary.TabStop = false;
            this.btnRemoveFromVocabulary.Text = "Remove from Vocabulary";
            this.btnRemoveFromVocabulary.UseVisualStyleBackColor = true;
            this.btnRemoveFromVocabulary.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pbLeft
            // 
            this.pbLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbLeft.Image = global::English_Project.Properties.Resources.goku_60;
            this.pbLeft.Location = new System.Drawing.Point(183, 297);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(80, 52);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeft.TabIndex = 18;
            this.pbLeft.TabStop = false;
            // 
            // pbRight
            // 
            this.pbRight.Image = global::English_Project.Properties.Resources._7;
            this.pbRight.Location = new System.Drawing.Point(480, 306);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(83, 62);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRight.TabIndex = 17;
            this.pbRight.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::English_Project.Properties.Resources._6;
            this.pictureBox1.Location = new System.Drawing.Point(143, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(197, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Help Goku to beat his lazy version by learning new vocabs";
            // 
            // Vocabulary
            // 
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(734, 451);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemoveFromVocabulary);
            this.Controls.Add(this.btnAddToLearnDirect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProgressBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.lblProgressBar2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btGenerateRandomVocabGreen);
            this.Controls.Add(this.btGenerateRandomVocabRed);
            this.Controls.Add(this.btnRemoveFromToLearn);
            this.Controls.Add(this.btnRemoveFromLearned);
            this.Controls.Add(this.lblNoLearned);
            this.Controls.Add(this.btnLearned);
            this.Controls.Add(this.lblNoVocabs);
            this.Controls.Add(this.lblNoToLearn);
            this.Controls.Add(this.btnAddToLearn);
            this.Controls.Add(this.cbLearned);
            this.Controls.Add(this.cbToLearn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGenerateRandomVocabYellow);
            this.Controls.Add(this.cbVocabs);
            this.Controls.Add(this.btnBack);
            this.Name = "Vocabulary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocabulary";
            this.Load += new System.EventHandler(this.Vocabulary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btGenerateRandomVocabYellow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbToLearn;
        private System.Windows.Forms.ComboBox cbVocabs;
        private System.Windows.Forms.ComboBox cbLearned;
        private System.Windows.Forms.Button btnAddToLearn;
        private System.Windows.Forms.Label lblNoToLearn;
        private System.Windows.Forms.Label lblNoVocabs;
        private System.Windows.Forms.Button btnLearned;
        private System.Windows.Forms.Label lblNoLearned;
        private System.Windows.Forms.Button btnRemoveFromLearned;
        private System.Windows.Forms.Button btnRemoveFromToLearn;
        private System.Windows.Forms.Button btGenerateRandomVocabRed;
        private System.Windows.Forms.Button btGenerateRandomVocabGreen;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lblProgressBar2;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddToLearnDirect;
        private System.Windows.Forms.Button btnRemoveFromVocabulary;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}