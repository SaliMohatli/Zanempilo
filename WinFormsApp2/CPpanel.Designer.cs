namespace WinFormsApp2
{
    partial class CPpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPpanel));
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            pnlCPadd = new Panel();
            groupBox2 = new GroupBox();
            pnlCPupd = new Panel();
            groupBox3 = new GroupBox();
            pnlCPdel = new Panel();
            groupBox4 = new GroupBox();
            button1 = new Button();
            btnDelete2 = new Button();
            listView2 = new ListView();
            textBox7 = new TextBox();
            label9 = new Label();
            btnCancel2 = new Button();
            btnConfirm = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            listView1 = new ListView();
            textBox6 = new TextBox();
            label8 = new Label();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCPadd.SuspendLayout();
            groupBox2.SuspendLayout();
            pnlCPupd.SuspendLayout();
            groupBox3.SuspendLayout();
            pnlCPdel.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold);
            label5.Location = new Point(514, 72);
            label5.Name = "label5";
            label5.Size = new Size(314, 53);
            label5.TabIndex = 25;
            label5.Text = "Add new client";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
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
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkOliveGreen;
            btnSearch.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnSearch.Location = new Point(7, 217);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(269, 55);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search client";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkOliveGreen;
            btnDelete.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnDelete.Location = new Point(7, 155);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(269, 55);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete client";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOliveGreen;
            btnUpdate.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(7, 92);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(269, 55);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update client info";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkOliveGreen;
            btnAdd.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnAdd.Location = new Point(7, 29);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(269, 55);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add new client";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pnlCPadd
            // 
            pnlCPadd.Controls.Add(groupBox2);
            pnlCPadd.Location = new Point(319, 176);
            pnlCPadd.Name = "pnlCPadd";
            pnlCPadd.Size = new Size(982, 653);
            pnlCPadd.TabIndex = 26;
            pnlCPadd.Visible = false;
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
            groupBox2.Location = new Point(3, 29);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(961, 535);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            groupBox2.Visible = false;
            // 
            // pnlCPupd
            // 
            pnlCPupd.Controls.Add(pnlCPdel);
            pnlCPupd.Controls.Add(groupBox3);
            pnlCPupd.Location = new Point(304, 139);
            pnlCPupd.Name = "pnlCPupd";
            pnlCPupd.Size = new Size(988, 656);
            pnlCPupd.TabIndex = 21;
            pnlCPupd.Visible = false;
            pnlCPupd.Paint += pnlCPupd_Paint;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCancel2);
            groupBox3.Controls.Add(btnConfirm);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(listView1);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label8);
            groupBox3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            groupBox3.Location = new Point(32, 66);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(976, 624);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Results";
            groupBox3.Visible = false;
            // 
            // pnlCPdel
            // 
            pnlCPdel.Controls.Add(groupBox4);
            pnlCPdel.Location = new Point(15, 37);
            pnlCPdel.Name = "pnlCPdel";
            pnlCPdel.Size = new Size(979, 653);
            pnlCPdel.TabIndex = 21;
            pnlCPdel.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(btnDelete2);
            groupBox4.Controls.Add(listView2);
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(label9);
            groupBox4.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            groupBox4.Location = new Point(0, 29);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(976, 620);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Results";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            button1.Location = new Point(405, 475);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 55);
            button1.TabIndex = 21;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
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
            // listView2
            // 
            listView2.Location = new Point(7, 92);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(963, 297);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(216, 33);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(322, 38);
            textBox7.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 38);
            label9.Name = "label9";
            label9.Size = new Size(147, 30);
            label9.TabIndex = 0;
            label9.Text = "Search client ID:";
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
            // textBox4
            // 
            textBox4.Location = new Point(216, 480);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 38);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(216, 420);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(322, 38);
            textBox5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 481);
            label6.Name = "label6";
            label6.Size = new Size(161, 30);
            label6.TabIndex = 4;
            label6.Text = "Change password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 425);
            label7.Name = "label7";
            label7.Size = new Size(165, 30);
            label7.TabIndex = 3;
            label7.Text = "Change username:";
            // 
            // listView1
            // 
            listView1.Location = new Point(7, 92);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(963, 297);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(216, 33);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(322, 38);
            textBox6.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 38);
            label8.Name = "label8";
            label8.Size = new Size(147, 30);
            label8.TabIndex = 0;
            label8.Text = "Search client ID:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkOliveGreen;
            btnCancel.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnCancel.Location = new Point(391, 416);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 55);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAddC
            // 
            btnAddC.BackColor = Color.DarkOliveGreen;
            btnAddC.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnAddC.Location = new Point(217, 416);
            btnAddC.Margin = new Padding(3, 4, 3, 4);
            btnAddC.Name = "btnAddC";
            btnAddC.Size = new Size(115, 55);
            btnAddC.TabIndex = 19;
            btnAddC.Text = "Add";
            btnAddC.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(217, 221);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 38);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 159);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 38);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 101);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 38);
            textBox1.TabIndex = 6;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(333, 37);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 34);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(217, 37);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 34);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Yes";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label4.Location = new Point(41, 233);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label3.Location = new Point(41, 170);
            label3.Name = "label3";
            label3.Size = new Size(32, 30);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label2.Location = new Point(41, 107);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Admin:";
            // 
            // CPpanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(1313, 844);
            Controls.Add(pnlCPupd);
            Controls.Add(pnlCPadd);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "CPpanel";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCPadd.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pnlCPupd.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            pnlCPdel.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private PictureBox pictureBox1;
        private Panel pnlCPadd;
        private Panel pnlCPupd;
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
        private Panel pnlCPdel;
        private GroupBox groupBox3;
        private Button btnCancel2;
        private Button btnConfirm;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private ListView listView1;
        private TextBox textBox6;
        private Label label8;
        private GroupBox groupBox4;
        private Button button1;
        private Button btnDelete2;
        private ListView listView2;
        private TextBox textBox7;
        private Label label9;
    }
}