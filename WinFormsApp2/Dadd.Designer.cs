namespace WinFormsApp2
{
    partial class Dadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dadd));
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
            btnDSearch = new Button();
            btnDDelete = new Button();
            btnDUpdate = new Button();
            btnDAdd = new Button();
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
            label5.Location = new Point(515, 71);
            label5.Name = "label5";
            label5.Size = new Size(321, 53);
            label5.TabIndex = 25;
            label5.Text = "Add new donor";
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
            groupBox2.Location = new Point(317, 204);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(983, 624);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
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
            radioButton2.Location = new Point(333, 35);
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
            radioButton1.Location = new Point(217, 35);
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
            label4.Location = new Point(41, 231);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label3.Location = new Point(41, 168);
            label3.Name = "label3";
            label3.Size = new Size(32, 30);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label2.Location = new Point(41, 105);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold);
            label1.Location = new Point(41, 43);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Admin:";
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
            btnDSearch.Click += btnDSearch_Click;
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
            btnDDelete.Click += btnDDelete_Click;
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
            btnDUpdate.Click += btnDUpdate_Click;
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
            btnDAdd.Click += btnDAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Dadd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(1313, 844);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dadd";
            Text = "Form2";
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
        private Button btnDSearch;
        private Button btnDDelete;
        private Button btnDUpdate;
        private Button btnDAdd;
        private PictureBox pictureBox1;
    }
}