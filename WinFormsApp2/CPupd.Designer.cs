namespace WinFormsApp2
{
    partial class CPupd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPupd));
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
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            groupBox2.Location = new Point(277, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(860, 468);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // btnCancel2
            // 
            btnCancel2.BackColor = Color.DarkOliveGreen;
            btnCancel2.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnCancel2.Location = new Point(345, 409);
            btnCancel2.Name = "btnCancel2";
            btnCancel2.Size = new Size(101, 41);
            btnCancel2.TabIndex = 21;
            btnCancel2.Text = "Cancel";
            btnCancel2.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.DarkOliveGreen;
            btnConfirm.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnConfirm.Location = new Point(217, 409);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(101, 41);
            btnConfirm.TabIndex = 20;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 32);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 315);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 32);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 360);
            label3.Name = "label3";
            label3.Size = new Size(128, 24);
            label3.TabIndex = 4;
            label3.Text = "Change password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 318);
            label2.Name = "label2";
            label2.Size = new Size(131, 24);
            label2.TabIndex = 3;
            label2.Text = "Change username:";
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
            groupBox1.TabIndex = 18;
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
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold);
            label4.Location = new Point(458, 56);
            label4.Name = "label4";
            label4.Size = new Size(290, 42);
            label4.TabIndex = 22;
            label4.Text = "Update client info";
            // 
            // CPupd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(1149, 633);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CPupd";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private ListView listView1;
        private TextBox textBox1;
        private Button btnCancel2;
        private Button btnConfirm;
        private Label label4;
    }
}