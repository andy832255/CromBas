namespace CromBas
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
            btnStart = new Button();
            txtClue1 = new TextBox();
            txtClue2 = new TextBox();
            txtClue3 = new TextBox();
            rBtn3 = new RadioButton();
            rBtn2 = new RadioButton();
            rBtn1 = new RadioButton();
            rBtn6 = new RadioButton();
            rBtn5 = new RadioButton();
            rBtn4 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtDelay = new TextBox();
            label4 = new Label();
            btnFive = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = Color.Red;
            btnStart.Location = new Point(45, 256);
            btnStart.Margin = new Padding(4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(121, 64);
            btnStart.TabIndex = 0;
            btnStart.Text = "猜25次";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtClue1
            // 
            txtClue1.Location = new Point(45, 157);
            txtClue1.Margin = new Padding(4);
            txtClue1.Name = "txtClue1";
            txtClue1.Size = new Size(132, 24);
            txtClue1.TabIndex = 1;
            // 
            // txtClue2
            // 
            txtClue2.Location = new Point(283, 157);
            txtClue2.Margin = new Padding(4);
            txtClue2.Name = "txtClue2";
            txtClue2.Size = new Size(132, 24);
            txtClue2.TabIndex = 2;
            // 
            // txtClue3
            // 
            txtClue3.Location = new Point(509, 157);
            txtClue3.Margin = new Padding(4);
            txtClue3.Name = "txtClue3";
            txtClue3.Size = new Size(132, 24);
            txtClue3.TabIndex = 3;
            // 
            // rBtn3
            // 
            rBtn3.AutoSize = true;
            rBtn3.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtn3.Location = new Point(43, 94);
            rBtn3.Margin = new Padding(4);
            rBtn3.Name = "rBtn3";
            rBtn3.Size = new Size(33, 20);
            rBtn3.TabIndex = 7;
            rBtn3.Text = "*";
            rBtn3.UseVisualStyleBackColor = true;
            // 
            // rBtn2
            // 
            rBtn2.AutoSize = true;
            rBtn2.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtn2.Location = new Point(43, 57);
            rBtn2.Margin = new Padding(4);
            rBtn2.Name = "rBtn2";
            rBtn2.Size = new Size(30, 20);
            rBtn2.TabIndex = 6;
            rBtn2.Text = "-";
            rBtn2.UseVisualStyleBackColor = true;
            // 
            // rBtn1
            // 
            rBtn1.AutoSize = true;
            rBtn1.Checked = true;
            rBtn1.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtn1.Location = new Point(43, 24);
            rBtn1.Margin = new Padding(4);
            rBtn1.Name = "rBtn1";
            rBtn1.Size = new Size(33, 20);
            rBtn1.TabIndex = 5;
            rBtn1.TabStop = true;
            rBtn1.Text = "+";
            rBtn1.UseVisualStyleBackColor = true;
            // 
            // rBtn6
            // 
            rBtn6.AutoSize = true;
            rBtn6.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtn6.Location = new Point(449, 197);
            rBtn6.Margin = new Padding(4);
            rBtn6.Name = "rBtn6";
            rBtn6.Size = new Size(33, 20);
            rBtn6.TabIndex = 10;
            rBtn6.Text = "*";
            rBtn6.UseVisualStyleBackColor = true;
            // 
            // rBtn5
            // 
            rBtn5.AutoSize = true;
            rBtn5.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtn5.Location = new Point(449, 160);
            rBtn5.Margin = new Padding(4);
            rBtn5.Name = "rBtn5";
            rBtn5.Size = new Size(30, 20);
            rBtn5.TabIndex = 9;
            rBtn5.Text = "-";
            rBtn5.UseVisualStyleBackColor = true;
            // 
            // rBtn4
            // 
            rBtn4.AutoSize = true;
            rBtn4.Checked = true;
            rBtn4.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtn4.Location = new Point(449, 128);
            rBtn4.Margin = new Padding(4);
            rBtn4.Name = "rBtn4";
            rBtn4.Size = new Size(33, 20);
            rBtn4.TabIndex = 8;
            rBtn4.TabStop = true;
            rBtn4.Text = "+";
            rBtn4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 11;
            label1.Text = "線索一";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(304, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 12;
            label2.Text = "線索二";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(531, 81);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 24);
            label3.TabIndex = 13;
            label3.Text = "線索三";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rBtn2);
            groupBox1.Controls.Add(rBtn1);
            groupBox1.Controls.Add(rBtn3);
            groupBox1.Location = new Point(187, 103);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(88, 149);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtDelay
            // 
            txtDelay.Location = new Point(619, 264);
            txtDelay.Margin = new Padding(4);
            txtDelay.Name = "txtDelay";
            txtDelay.Size = new Size(65, 24);
            txtDelay.TabIndex = 15;
            txtDelay.Text = "25";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(444, 255);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 24);
            label4.TabIndex = 16;
            label4.Text = "輸入延遲(ms)";
            // 
            // btnFive
            // 
            btnFive.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFive.ForeColor = SystemColors.ControlText;
            btnFive.Location = new Point(283, 255);
            btnFive.Margin = new Padding(4);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(133, 65);
            btnFive.TabIndex = 17;
            btnFive.Text = "猜5次";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 384);
            Controls.Add(btnFive);
            Controls.Add(label4);
            Controls.Add(txtDelay);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rBtn6);
            Controls.Add(rBtn5);
            Controls.Add(rBtn4);
            Controls.Add(txtClue3);
            Controls.Add(txtClue2);
            Controls.Add(txtClue1);
            Controls.Add(btnStart);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "CromBas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox txtClue1;
        private TextBox txtClue2;
        private TextBox txtClue3;
        private RadioButton rBtn3;
        private RadioButton rBtn2;
        private RadioButton rBtn1;
        private RadioButton rBtn6;
        private RadioButton rBtn5;
        private RadioButton rBtn4;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtDelay;
        private Label label4;
        private Button btnFive;
    }
}