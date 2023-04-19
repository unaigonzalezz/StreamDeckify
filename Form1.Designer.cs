namespace StreamDeckify
{
    partial class StreamDeckify
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StreamDeckify));
            pictureBox1 = new PictureBox();
            settings = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(881, 173);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // settings
            // 
            settings.BackColor = Color.Transparent;
            settings.BackgroundImage = (Image)resources.GetObject("settings.BackgroundImage");
            settings.BackgroundImageLayout = ImageLayout.Center;
            settings.CausesValidation = false;
            settings.Cursor = Cursors.Hand;
            settings.FlatAppearance.BorderSize = 0;
            settings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            settings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            settings.FlatStyle = FlatStyle.Flat;
            settings.ForeColor = Color.Transparent;
            settings.Location = new Point(821, 9);
            settings.Margin = new Padding(0);
            settings.Name = "settings";
            settings.Size = new Size(27, 29);
            settings.TabIndex = 1;
            settings.UseVisualStyleBackColor = false;
            settings.Click += settings_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(-2, 157);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(437, 332);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(431, 157);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(430, 332);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // StreamDeckify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 19, 19);
            ClientSize = new Size(856, 485);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(settings);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StreamDeckify";
            Text = "StreamDeckify";
            TransparencyKey = SystemColors.ControlDarkDark;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button settings;
        private Button button1;
        private Button button2;
    }
}