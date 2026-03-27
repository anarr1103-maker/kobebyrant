namespace Anar5455
{
    partial class MOVIE_FROM
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
            dgvMovie = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtTitle = new TextBox();
            txtYear = new TextBox();
            txtDirector = new TextBox();
            label4 = new Label();
            btnzasah = new Button();
            btnAdd = new Button();
            picMovie = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMovie).BeginInit();
            SuspendLayout();
            // 
            // dgvMovie
            // 
            dgvMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovie.Location = new Point(17, 12);
            dgvMovie.Name = "dgvMovie";
            dgvMovie.ReadOnly = true;
            dgvMovie.Size = new Size(771, 150);
            dgvMovie.TabIndex = 0;
            dgvMovie.CellClick += dgvMovie_CellClick;
            dgvMovie.CellContentClick += dgvMovie_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 196);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 196);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Kinoni Ner";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 196);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 3;
            label3.Text = "On";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 214);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(132, 214);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(269, 214);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 7;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(408, 214);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(100, 23);
            txtDirector.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 196);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 9;
            label4.Text = "Nairuulagch";
            // 
            // btnzasah
            // 
            btnzasah.Location = new Point(553, 214);
            btnzasah.Name = "btnzasah";
            btnzasah.Size = new Size(75, 50);
            btnzasah.TabIndex = 10;
            btnzasah.Text = "Zasah";
            btnzasah.UseVisualStyleBackColor = true;
            btnzasah.Click += btnzasah_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(553, 281);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 47);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Nemeh";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // picMovie
            // 
            picMovie.Location = new Point(17, 269);
            picMovie.Name = "picMovie";
            picMovie.Size = new Size(312, 300);
            picMovie.TabIndex = 12;
            picMovie.TabStop = false;
            picMovie.Click += pictureBox1_Click;
            // 
            // MOVIE_FROM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 581);
            Controls.Add(picMovie);
            Controls.Add(btnAdd);
            Controls.Add(btnzasah);
            Controls.Add(label4);
            Controls.Add(txtDirector);
            Controls.Add(txtYear);
            Controls.Add(txtTitle);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMovie);
            Name = "MOVIE_FROM";
            Text = "MOVIE_FROM";
            Load += MOVIE_FROM_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMovie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMovie;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtTitle;
        private TextBox txtYear;
        private TextBox txtDirector;
        private Label label4;
        private Button btnzasah;
        private Button btnAdd;
        private PictureBox picMovie;
    }
}