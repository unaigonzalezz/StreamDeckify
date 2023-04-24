namespace StreamDeckify
{
    partial class ResizeImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizeImages));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            browse = new Button();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(881, 173);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(490, 173);
            label2.Name = "label2";
            label2.Size = new Size(0, 27);
            label2.TabIndex = 3;
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(438, 182);
            label1.Name = "label1";
            label1.Size = new Size(277, 30);
            label1.TabIndex = 4;
            label1.Text = "1. Select your StreamDeck";
            label1.UseCompatibleTextRendering = true;
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Stream Deck Mini", "Stream Deck / MK.2", "Stream Deck +", "Stream Deck XL" });
            comboBox1.Location = new Point(438, 215);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 23);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(438, 260);
            label3.Name = "label3";
            label3.Size = new Size(226, 30);
            label3.TabIndex = 6;
            label3.Text = "2. Upload your photo";
            label3.UseCompatibleTextRendering = true;
            label3.Click += label3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // browse
            // 
            browse.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            browse.Location = new Point(438, 293);
            browse.Name = "browse";
            browse.Size = new Size(106, 23);
            browse.TabIndex = 7;
            browse.Text = "Select";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(561, 297);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            label4.Click += label4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 163);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(385, 275);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(438, 338);
            label5.Name = "label5";
            label5.Size = new Size(106, 30);
            label5.TabIndex = 10;
            label5.Text = "3. Save it!";
            label5.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            button1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(438, 371);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(438, 407);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 12;
            // 
            // ResizeImages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(857, 450);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(browse);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Name = "ResizeImages";
            Text = "ResizeImages - StreamDeckify";
            TransparencyKey = Color.Magenta;
            Load += ResizeImages_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private Button browse;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label5;
        private Button button1;
        private Label label6;
        private SaveFileDialog saveFileDialog1;
    }
}