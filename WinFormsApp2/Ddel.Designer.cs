namespace WinFormsApp2
{
    partial class Donor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donor));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnCancel2 = new Button();
            btnDelete2 = new Button();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold);
            label2.Location = new Point(535, 65);
            label2.Name = "label2";
            label2.Size = new Size(302, 53);
            label2.TabIndex = 32;
            label2.Text = "Delete donors";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancel2);
            groupBox2.Controls.Add(btnDelete2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            groupBox2.Location = new Point(317, 204);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(983, 624);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // btnCancel2
            // 
            btnCancel2.BackColor = Color.DarkOliveGreen;
            btnCancel2.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnCancel2.Location = new Point(405, 475);
            btnCancel2.Margin = new Padding(3, 4, 3, 4);
            btnCancel2.Name = "btnCancel2";
            btnCancel2.Size = new Size(115, 55);
            btnCancel2.TabIndex = 21;
            btnCancel2.Text = "Cancel";
            btnCancel2.UseVisualStyleBackColor = false;
            // 
            // btnDelete2
            // 
            btnDelete2.BackColor = Color.DarkOliveGreen;
            btnDelete2.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnDelete2.Location = new Point(243, 475);
            btnDelete2.Margin = new Padding(3, 4, 3, 4);
            btnDelete2.Name = "btnDelete2";
            btnDelete2.Size = new Size(115, 55);
            btnDelete2.TabIndex = 20;
            btnDelete2.Text = "Delete";
            btnDelete2.UseVisualStyleBackColor = false;
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
            label1.Location = new Point(43, 37);
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
            groupBox1.Location = new Point(14, 204);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(285, 624);
            groupBox1.TabIndex = 29;
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
            // 
            // Donor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(1313, 844);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Donor";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnCancel2;
        private Button btnDelete2;
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