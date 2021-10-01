
namespace Lab_1_lineal
{
    partial class InfixPostfixForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfixPostfixForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.EnterInfixBox = new System.Windows.Forms.TextBox();
            this.ToPostfixButton = new System.Windows.Forms.Button();
            this.EnterElLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostfixLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(688, 556);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(127, 37);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EnterInfixBox
            // 
            this.EnterInfixBox.Location = new System.Drawing.Point(54, 257);
            this.EnterInfixBox.Name = "EnterInfixBox";
            this.EnterInfixBox.Size = new System.Drawing.Size(235, 22);
            this.EnterInfixBox.TabIndex = 14;
            this.EnterInfixBox.TextChanged += new System.EventHandler(this.EnterInfixBox_TextChanged);
            // 
            // ToPostfixButton
            // 
            this.ToPostfixButton.BackColor = System.Drawing.Color.RosyBrown;
            this.ToPostfixButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToPostfixButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToPostfixButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToPostfixButton.Location = new System.Drawing.Point(323, 257);
            this.ToPostfixButton.Name = "ToPostfixButton";
            this.ToPostfixButton.Size = new System.Drawing.Size(154, 39);
            this.ToPostfixButton.TabIndex = 39;
            this.ToPostfixButton.Text = "To postfix->";
            this.ToPostfixButton.UseVisualStyleBackColor = false;
            this.ToPostfixButton.Click += new System.EventHandler(this.ToPostfixButton_Click);
            // 
            // EnterElLabel
            // 
            this.EnterElLabel.AutoSize = true;
            this.EnterElLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterElLabel.Location = new System.Drawing.Point(50, 194);
            this.EnterElLabel.Name = "EnterElLabel";
            this.EnterElLabel.Size = new System.Drawing.Size(110, 24);
            this.EnterElLabel.TabIndex = 40;
            this.EnterElLabel.Text = "Enter Infix:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(514, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Postfix:";
            // 
            // PostfixLabel
            // 
            this.PostfixLabel.AutoSize = true;
            this.PostfixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostfixLabel.Location = new System.Drawing.Point(524, 255);
            this.PostfixLabel.Name = "PostfixLabel";
            this.PostfixLabel.Size = new System.Drawing.Size(168, 24);
            this.PostfixLabel.TabIndex = 42;
            this.PostfixLabel.Text = "Here will be postfix";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab_1_lineal.Properties.Resources.imgonline_com_ua_Resize_NhDqcfbjlr1W3;
            this.pictureBox2.Location = new System.Drawing.Point(304, 368);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 189);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_1_lineal.Properties.Resources.full1;
            this.pictureBox1.Location = new System.Drawing.Point(-54, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 92);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // InfixPostfixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(827, 605);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PostfixLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterElLabel);
            this.Controls.Add(this.ToPostfixButton);
            this.Controls.Add(this.EnterInfixBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfixPostfixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infix->postfix";
            this.Load += new System.EventHandler(this.InfixPostfixForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox EnterInfixBox;
        private System.Windows.Forms.Button ToPostfixButton;
        private System.Windows.Forms.Label EnterElLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PostfixLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}