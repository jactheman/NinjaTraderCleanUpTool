namespace NinjaTraderCleanUpTool
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
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button2 = new Button();
            textBox1 = new TextBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(179, 376);
            button1.Name = "button1";
            button1.Size = new Size(229, 45);
            button1.TabIndex = 0;
            button1.Text = "Run NinjaTrader Cleanup";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(179, 59);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(192, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Delete Cache Folder (db\\cache)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(178, 85);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(179, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Delete (db\\[minute day tick])";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += CheckBox2_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(513, 23);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 4;
            button2.Text = "NT Directory";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 5;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(179, 110);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(159, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Delete Replay (db\\replay)";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += CheckBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.Location = new Point(179, 135);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(82, 19);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Delete Log";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.Location = new Point(177, 161);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(84, 19);
            checkBox5.TabIndex = 8;
            checkBox5.Text = "Delete tmp";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = SystemColors.ActiveCaption;
            checkBox6.ForeColor = Color.Black;
            checkBox6.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox6.Location = new Point(179, 186);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(199, 19);
            checkBox6.TabIndex = 9;
            checkBox6.Text = "Delete DB (db\\NinjaTrader.sqlite)";
            checkBox6.UseVisualStyleBackColor = false;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "NinjaTrader Cleanup Tool";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion


        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
        private TextBox textBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
    }
}