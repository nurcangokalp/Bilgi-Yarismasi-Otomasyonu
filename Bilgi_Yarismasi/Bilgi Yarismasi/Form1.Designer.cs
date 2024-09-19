namespace Pratik2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            LblSoruno = new Label();
            LblDogru = new Label();
            LblYanlis = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(128, 255, 128);
            richTextBox1.Location = new Point(2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(389, 204);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.BackColor = Color.Silver;
            BtnA.Location = new Point(2, 212);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(196, 54);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = false;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.BackColor = Color.Silver;
            BtnB.Location = new Point(204, 212);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(187, 54);
            BtnB.TabIndex = 2;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = false;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.BackColor = Color.Silver;
            BtnC.Location = new Point(2, 272);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(196, 57);
            BtnC.TabIndex = 3;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = false;
            BtnC.Click += BtnC_Click;
            // 
            // BtnD
            // 
            BtnD.BackColor = Color.Silver;
            BtnD.Location = new Point(204, 272);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(187, 57);
            BtnD.TabIndex = 4;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = false;
            BtnD.Click += BtnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 6);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(496, 53);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 107);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // BtnSonraki
            // 
            BtnSonraki.BackColor = Color.Goldenrod;
            BtnSonraki.Location = new Point(457, 149);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(197, 38);
            BtnSonraki.TabIndex = 11;
            BtnSonraki.Text = "Sonraki Soru";
            BtnSonraki.UseVisualStyleBackColor = false;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(416, 204);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(571, 204);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 379);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(313, 419);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // LblSoruno
            // 
            LblSoruno.AutoSize = true;
            LblSoruno.Location = new Point(572, 10);
            LblSoruno.Name = "LblSoruno";
            LblSoruno.Size = new Size(20, 23);
            LblSoruno.TabIndex = 16;
            LblSoruno.Text = "0";
            // 
            // LblDogru
            // 
            LblDogru.AutoSize = true;
            LblDogru.Location = new Point(571, 53);
            LblDogru.Name = "LblDogru";
            LblDogru.Size = new Size(20, 23);
            LblDogru.TabIndex = 17;
            LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            LblYanlis.AutoSize = true;
            LblYanlis.Location = new Point(572, 107);
            LblYanlis.Name = "LblYanlis";
            LblYanlis.Size = new Size(20, 23);
            LblYanlis.TabIndex = 18;
            LblYanlis.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(708, 346);
            Controls.Add(LblYanlis);
            Controls.Add(LblDogru);
            Controls.Add(LblSoruno);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSonraki);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Label LblSoruno;
        private Label LblDogru;
        private Label LblYanlis;
    }
}
