namespace WinFormsApp2
{
    partial class CPaddd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPaddd));
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnCancel = new Button();
            btnAddC = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold);
            label5.Location = new Point(451, 53);
            label5.Name = "label5";
            label5.Size = new Size(248, 42);
            label5.TabIndex = 25;
            label5.Text = "Add new client";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancel);
            groupBox2.Controls.Add(btnAddC);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            groupBox2.Location = new Point(277, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(860, 468);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkOliveGreen;
            btnCancel.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnCancel.Location = new Point(342, 312);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 41);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAddC
            // 
            btnAddC.BackColor = Color.DarkOliveGreen;
            btnAddC.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnAddC.Location = new Point(190, 312);
            btnAddC.Name = "btnAddC";
            btnAddC.Size = new Size(101, 41);
            btnAddC.TabIndex = 19;
            btnAddC.Text = "Add";
            btnAddC.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(190, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 32);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 32);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 32);
            textBox1.TabIndex = 6;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(291, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 28);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(190, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 28);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Yes";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label4.Location = new Point(36, 173);
            label4.Name = "label4";
            label4.Size = new Size(77, 24);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label3.Location = new Point(36, 126);
            label3.Name = "label3";
            label3.Size = new Size(25, 24);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label2.Location = new Point(36, 79);
            label2.Name = "label2";
            label2.Size = new Size(79, 24);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label1.Location = new Point(36, 32);
            label1.Name = "label1";
            label1.Size = new Size(55, 24);
            label1.TabIndex = 0;
            label1.Text = "Admin:";
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
            groupBox1.TabIndex = 23;
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
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // CPaddd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(1149, 633);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "CPaddd";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private GroupBox groupBox2;
        private Button btnCancel;
        private Button btnAddC;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private PictureBox pictureBox1;
    }
}