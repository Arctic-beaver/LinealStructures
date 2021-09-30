
namespace Lab_1_lineal
{
    partial class StackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StackForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.PopButton = new System.Windows.Forms.Button();
            this.PushButton = new System.Windows.Forms.Button();
            this.PeekButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NextAddButton = new System.Windows.Forms.Button();
            this.mainArrayLabel = new System.Windows.Forms.Label();
            this.mainArrayBox = new System.Windows.Forms.TextBox();
            this.YourListLabel = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.ContainsButton = new System.Windows.Forms.Button();
            this.CountButton = new System.Windows.Forms.Button();
            this.ContainsNextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // PopButton
            // 
            this.PopButton.BackColor = System.Drawing.Color.Bisque;
            this.PopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PopButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopButton.Location = new System.Drawing.Point(339, 115);
            this.PopButton.Name = "PopButton";
            this.PopButton.Size = new System.Drawing.Size(145, 61);
            this.PopButton.TabIndex = 15;
            this.PopButton.Text = "Pop";
            this.PopButton.UseVisualStyleBackColor = false;
            this.PopButton.Click += new System.EventHandler(this.PopButton_Click);
            // 
            // PushButton
            // 
            this.PushButton.BackColor = System.Drawing.Color.Bisque;
            this.PushButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PushButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PushButton.Location = new System.Drawing.Point(112, 115);
            this.PushButton.Name = "PushButton";
            this.PushButton.Size = new System.Drawing.Size(145, 61);
            this.PushButton.TabIndex = 16;
            this.PushButton.TabStop = false;
            this.PushButton.Text = "Push";
            this.PushButton.UseVisualStyleBackColor = false;
            this.PushButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PeekButton
            // 
            this.PeekButton.BackColor = System.Drawing.Color.Bisque;
            this.PeekButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PeekButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeekButton.Location = new System.Drawing.Point(567, 115);
            this.PeekButton.Name = "PeekButton";
            this.PeekButton.Size = new System.Drawing.Size(145, 61);
            this.PeekButton.TabIndex = 17;
            this.PeekButton.Text = "Peek";
            this.PeekButton.UseVisualStyleBackColor = false;
            this.PeekButton.Click += new System.EventHandler(this.PeekButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_1_lineal.Properties.Resources.full1;
            this.pictureBox1.Location = new System.Drawing.Point(-54, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 92);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab_1_lineal.Properties.Resources.full1;
            this.pictureBox2.Location = new System.Drawing.Point(-54, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(908, 92);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // NextAddButton
            // 
            this.NextAddButton.BackColor = System.Drawing.Color.RosyBrown;
            this.NextAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextAddButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextAddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextAddButton.Location = new System.Drawing.Point(675, 337);
            this.NextAddButton.Name = "NextAddButton";
            this.NextAddButton.Size = new System.Drawing.Size(127, 30);
            this.NextAddButton.TabIndex = 44;
            this.NextAddButton.UseVisualStyleBackColor = false;
            this.NextAddButton.Click += new System.EventHandler(this.NextAddButton_Click);
            // 
            // mainArrayLabel
            // 
            this.mainArrayLabel.AutoSize = true;
            this.mainArrayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainArrayLabel.Location = new System.Drawing.Point(144, 278);
            this.mainArrayLabel.Name = "mainArrayLabel";
            this.mainArrayLabel.Size = new System.Drawing.Size(96, 24);
            this.mainArrayLabel.TabIndex = 43;
            this.mainArrayLabel.Text = "Welcome!";
            this.mainArrayLabel.Click += new System.EventHandler(this.mainArrayLabel_Click);
            // 
            // mainArrayBox
            // 
            this.mainArrayBox.Location = new System.Drawing.Point(148, 339);
            this.mainArrayBox.Name = "mainArrayBox";
            this.mainArrayBox.Size = new System.Drawing.Size(502, 22);
            this.mainArrayBox.TabIndex = 42;
            this.mainArrayBox.TextChanged += new System.EventHandler(this.mainArrayBox_TextChanged);
            // 
            // YourListLabel
            // 
            this.YourListLabel.AutoSize = true;
            this.YourListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourListLabel.Location = new System.Drawing.Point(144, 411);
            this.YourListLabel.Name = "YourListLabel";
            this.YourListLabel.Size = new System.Drawing.Size(113, 24);
            this.YourListLabel.TabIndex = 41;
            this.YourListLabel.Text = "Your stack:";
            this.YourListLabel.Click += new System.EventHandler(this.YourListLabel_Click);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListLabel.Location = new System.Drawing.Point(144, 445);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(189, 24);
            this.ListLabel.TabIndex = 40;
            this.ListLabel.Text = "Here must be stack";
            this.ListLabel.Click += new System.EventHandler(this.ListLabel_Click);
            // 
            // ContainsButton
            // 
            this.ContainsButton.BackColor = System.Drawing.Color.Bisque;
            this.ContainsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContainsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainsButton.Location = new System.Drawing.Point(241, 193);
            this.ContainsButton.Name = "ContainsButton";
            this.ContainsButton.Size = new System.Drawing.Size(145, 61);
            this.ContainsButton.TabIndex = 46;
            this.ContainsButton.Text = "Contains";
            this.ContainsButton.UseVisualStyleBackColor = false;
            this.ContainsButton.Click += new System.EventHandler(this.ContainsButton_Click);
            // 
            // CountButton
            // 
            this.CountButton.BackColor = System.Drawing.Color.Bisque;
            this.CountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CountButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountButton.Location = new System.Drawing.Point(460, 193);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(145, 61);
            this.CountButton.TabIndex = 47;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = false;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // ContainsNextButton
            // 
            this.ContainsNextButton.BackColor = System.Drawing.Color.RosyBrown;
            this.ContainsNextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContainsNextButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainsNextButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContainsNextButton.Location = new System.Drawing.Point(656, 337);
            this.ContainsNextButton.Name = "ContainsNextButton";
            this.ContainsNextButton.Size = new System.Drawing.Size(127, 30);
            this.ContainsNextButton.TabIndex = 48;
            this.ContainsNextButton.Text = "Next";
            this.ContainsNextButton.UseVisualStyleBackColor = false;
            this.ContainsNextButton.Click += new System.EventHandler(this.ContainsNextButton_Click);
            // 
            // StackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(827, 605);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.ContainsButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.NextAddButton);
            this.Controls.Add(this.mainArrayLabel);
            this.Controls.Add(this.mainArrayBox);
            this.Controls.Add(this.YourListLabel);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.PeekButton);
            this.Controls.Add(this.PushButton);
            this.Controls.Add(this.PopButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ContainsNextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stack";
            this.Load += new System.EventHandler(this.StackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button PopButton;
        private System.Windows.Forms.Button PushButton;
        private System.Windows.Forms.Button PeekButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button NextAddButton;
        private System.Windows.Forms.Label mainArrayLabel;
        private System.Windows.Forms.TextBox mainArrayBox;
        private System.Windows.Forms.Label YourListLabel;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Button ContainsButton;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Button ContainsNextButton;
    }
}