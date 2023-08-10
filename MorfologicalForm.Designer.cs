
namespace APO
{
    partial class MorfologicalForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxKernelType = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBoxBorderType = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBoxKernelSize = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Operation";
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "Erode",
            "Dilate",
            "Open",
            "Close"});
            this.comboBoxOperation.Location = new System.Drawing.Point(13, 39);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOperation.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Kernel Type";
            // 
            // comboBoxKernelType
            // 
            this.comboBoxKernelType.FormattingEnabled = true;
            this.comboBoxKernelType.Items.AddRange(new object[] {
            "Cross",
            "Ellipse"});
            this.comboBoxKernelType.Location = new System.Drawing.Point(13, 92);
            this.comboBoxKernelType.Name = "comboBoxKernelType";
            this.comboBoxKernelType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKernelType.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Border Type";
            // 
            // comboBoxBorderType
            // 
            this.comboBoxBorderType.FormattingEnabled = true;
            this.comboBoxBorderType.Items.AddRange(new object[] {
            "Reflect",
            "Replicate",
            "Default"});
            this.comboBoxBorderType.Location = new System.Drawing.Point(13, 145);
            this.comboBoxBorderType.Name = "comboBoxBorderType";
            this.comboBoxBorderType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBorderType.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Kernel Size";
            // 
            // comboBoxKernelSize
            // 
            this.comboBoxKernelSize.FormattingEnabled = true;
            this.comboBoxKernelSize.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.comboBoxKernelSize.Location = new System.Drawing.Point(13, 198);
            this.comboBoxKernelSize.Name = "comboBoxKernelSize";
            this.comboBoxKernelSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKernelSize.TabIndex = 7;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(13, 226);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 8;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(94, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 10);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // MorfologicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(157, 261);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.comboBoxKernelSize);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBoxBorderType);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBoxKernelType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.textBox1);
            this.Name = "MorfologicalForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxKernelType;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBoxBorderType;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBoxKernelSize;
        private System.Windows.Forms.Button buttonApply;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}