namespace StreamDeckify
{
    partial class SplitImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitImages));
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            browse = new Button();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(881, 173);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Stream Deck Mini (6 buttons)", "Stream Deck / MK.2 (15 buttons)", "Stream Deck + (8 buttons)", "Stream Deck XL (32 buttons)" });
            comboBox1.Location = new Point(420, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(420, 181);
            label1.Name = "label1";
            label1.Size = new Size(277, 30);
            label1.TabIndex = 6;
            label1.Text = "1. Select your StreamDeck";
            label1.UseCompatibleTextRendering = true;
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 163);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(385, 275);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // browse
            // 
            browse.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            browse.Location = new Point(420, 286);
            browse.Name = "browse";
            browse.Size = new Size(106, 23);
            browse.TabIndex = 12;
            browse.Text = "Select";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(420, 253);
            label3.Name = "label3";
            label3.Size = new Size(226, 30);
            label3.TabIndex = 11;
            label3.Text = "2. Upload your photo";
            label3.UseCompatibleTextRendering = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(542, 290);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 13;
            label4.Click += label4_Click;
            // 
            // SplitImages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(854, 450);
            Controls.Add(label4);
            Controls.Add(browse);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SplitImages";
            Text = "SplitImages";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private Button browse;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private Label label4;
    }
}