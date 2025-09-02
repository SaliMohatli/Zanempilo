namespace WinFormsApp2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            btnlogg = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(452, 27);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label1.Location = new Point(402, 248);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 29;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label2.Location = new Point(402, 311);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 30;
            label2.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(497, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(497, 311);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold);
            label3.Location = new Point(429, 174);
            label3.Name = "label3";
            label3.Size = new Size(252, 42);
            label3.TabIndex = 33;
            label3.Text = "Welcome back!";
            // 
            // btnlogg
            // 
            btnlogg.BackColor = Color.DarkOliveGreen;
            btnlogg.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnlogg.Location = new Point(520, 433);
            btnlogg.Name = "btnlogg";
            btnlogg.Size = new Size(101, 41);
            btnlogg.TabIndex = 34;
            btnlogg.Text = "LOGIN";
            btnlogg.UseVisualStyleBackColor = false;
            btnlogg.Click += this.btnlogg_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(1149, 633);
            Controls.Add(btnlogg);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button btnlogg;
    }
}