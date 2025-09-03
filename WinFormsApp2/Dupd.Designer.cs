namespace WinFormsApp2
{
    partial class Dupd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dupd));
            label4 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnCancel2 = new Button();
            btnConfirm = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDSearch = new Button();
            btnDDelete = new Button();
            btnDUpdate = new Button();
            btnDAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold);
            label4.Location = new Point(522, 76);
            label4.Name = "label4";
            label4.Size = new Size(374, 53);
            label4.TabIndex = 26;
            label4.Text = "Update donor info";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancel2);
            groupBox2.Controls.Add(btnConfirm);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            groupBox2.Location = new Point(316, 205);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(983, 624);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // btnCancel2
            // 
            btnCancel2.BackColor = Color.DarkOliveGreen;
            btnCancel2.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnCancel2.Location = new Point(394, 545);
            btnCancel2.Margin = new Padding(3, 4, 3, 4);
            btnCancel2.Name = "btnCancel2";
            btnCancel2.Size = new Size(115, 55);
            btnCancel2.TabIndex = 21;
            btnCancel2.Text = "Cancel";
            btnCancel2.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.DarkOliveGreen;
            btnConfirm.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnConfirm.Location = new Point(248, 545);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(115, 55);
            btnConfirm.TabIndex = 20;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 480);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 38);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 420);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 38);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 481);
            label3.Name = "label3";
            label3.Size = new Size(161, 30);
            label3.TabIndex = 4;
            label3.Text = "Change password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 425);
            label2.Name = "label2";
            label2.Size = new Size(165, 30);
            label2.TabIndex = 3;
            label2.Text = "Change username:";
            // 
            // listView1
            // 
            listView1.Location = new Point(7, 92);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(969, 297);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 33);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 38);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 38);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 0;
            label1.Text = "Search client ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDSearch);
            groupBox1.Controls.Add(btnDDelete);
            groupBox1.Controls.Add(btnDUpdate);
            groupBox1.Controls.Add(btnDAdd);
            groupBox1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            groupBox1.Location = new Point(13, 205);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(285, 624);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnDSearch
            // 
            btnDSearch.BackColor = Color.DarkOliveGreen;
            btnDSearch.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnDSearch.Location = new Point(7, 217);
            btnDSearch.Margin = new Padding(3, 4, 3, 4);
            btnDSearch.Name = "btnDSearch";
            btnDSearch.Size = new Size(269, 55);
            btnDSearch.TabIndex = 18;
            btnDSearch.Text = "Search donor";
            btnDSearch.UseVisualStyleBackColor = false;
            // 
            // btnDDelete
            // 
            btnDDelete.BackColor = Color.DarkOliveGreen;
            btnDDelete.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnDDelete.Location = new Point(7, 155);
            btnDDelete.Margin = new Padding(3, 4, 3, 4);
            btnDDelete.Name = "btnDDelete";
            btnDDelete.Size = new Size(269, 55);
            btnDDelete.TabIndex = 17;
            btnDDelete.Text = "Delete donor";
            btnDDelete.UseVisualStyleBackColor = false;
            // 
            // btnDUpdate
            // 
            btnDUpdate.BackColor = Color.DarkOliveGreen;
            btnDUpdate.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnDUpdate.Location = new Point(7, 92);
            btnDUpdate.Margin = new Padding(3, 4, 3, 4);
            btnDUpdate.Name = "btnDUpdate";
            btnDUpdate.Size = new Size(269, 55);
            btnDUpdate.TabIndex = 16;
            btnDUpdate.Text = "Update donor info";
            btnDUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDAdd
            // 
            btnDAdd.BackColor = Color.DarkOliveGreen;
            btnDAdd.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnDAdd.Location = new Point(7, 29);
            btnDAdd.Margin = new Padding(3, 4, 3, 4);
            btnDAdd.Name = "btnDAdd";
            btnDAdd.Size = new Size(269, 55);
            btnDAdd.TabIndex = 15;
            btnDAdd.Text = "Add new donor";
            btnDAdd.UseVisualStyleBackColor = false;
            btnDAdd.Click += this.btnDAdd_Click;
            // 
            // Dupd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1313, 844);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Dupd";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnCancel2;
        private Button btnConfirm;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private ListView listView1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnDSearch;
        private Button btnDDelete;
        private Button btnDUpdate;
        private Button btnDAdd;
    }
}