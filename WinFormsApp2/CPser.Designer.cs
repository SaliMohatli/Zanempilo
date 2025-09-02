namespace WinFormsApp2
{
    partial class CPser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPser));
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnCancel2 = new Button();
            btnDelete2 = new Button();
            listView1 = new ListView();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
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
            groupBox2.Location = new Point(277, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(860, 468);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // btnCancel2
            // 
            btnCancel2.BackColor = Color.DarkOliveGreen;
            btnCancel2.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnCancel2.Location = new Point(354, 356);
            btnCancel2.Name = "btnCancel2";
            btnCancel2.Size = new Size(101, 41);
            btnCancel2.TabIndex = 21;
            btnCancel2.Text = "Cancel";
            btnCancel2.UseVisualStyleBackColor = false;
            // 
            // btnDelete2
            // 
            btnDelete2.BackColor = Color.DarkOliveGreen;
            btnDelete2.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnDelete2.Location = new Point(213, 356);
            btnDelete2.Name = "btnDelete2";
            btnDelete2.Size = new Size(101, 41);
            btnDelete2.TabIndex = 20;
            btnDelete2.Text = "Delete";
            btnDelete2.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 69);
            listView1.Name = "listView1";
            listView1.Size = new Size(848, 224);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 32);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 24);
            label1.TabIndex = 0;
            label1.Text = "Search client ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 468);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkOliveGreen;
            btnSearch.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnSearch.Location = new Point(6, 163);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(235, 41);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search client";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkOliveGreen;
            btnDelete.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnDelete.Location = new Point(6, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(235, 41);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete client";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOliveGreen;
            btnUpdate.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(6, 69);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(235, 41);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update client info";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkOliveGreen;
            btnAdd.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnAdd.Location = new Point(6, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(235, 41);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add new client";
            btnAdd.UseVisualStyleBackColor = false;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold);
            label2.Location = new Point(490, 56);
            label2.Name = "label2";
            label2.Size = new Size(225, 42);
            label2.TabIndex = 28;
            label2.Text = "Search client";
            // 
            // CPser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(1149, 633);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CPser";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnCancel2;
        private Button btnDelete2;
        private ListView listView1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label2;
    }
}