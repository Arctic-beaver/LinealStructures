
namespace Lab_1_lineal
{
    partial class ListForm
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
            list.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.NextAddButton = new System.Windows.Forms.Button();
            this.mainArrayLabel = new System.Windows.Forms.Label();
            this.mainArrayBox = new System.Windows.Forms.TextBox();
            this.YourListLabel = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.FilledLenghtButton = new System.Windows.Forms.Button();
            this.GetElementButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FindPositionButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
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
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextAddButton
            // 
            this.NextAddButton.BackColor = System.Drawing.Color.RosyBrown;
            this.NextAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextAddButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextAddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextAddButton.Location = new System.Drawing.Point(686, 358);
            this.NextAddButton.Name = "NextAddButton";
            this.NextAddButton.Size = new System.Drawing.Size(127, 30);
            this.NextAddButton.TabIndex = 38;
            this.NextAddButton.UseVisualStyleBackColor = false;
            this.NextAddButton.Click += new System.EventHandler(this.NextAddButton_Click);
            // 
            // mainArrayLabel
            // 
            this.mainArrayLabel.AutoSize = true;
            this.mainArrayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainArrayLabel.Location = new System.Drawing.Point(155, 299);
            this.mainArrayLabel.Name = "mainArrayLabel";
            this.mainArrayLabel.Size = new System.Drawing.Size(96, 24);
            this.mainArrayLabel.TabIndex = 37;
            this.mainArrayLabel.Text = "Welcome!";
            // 
            // mainArrayBox
            // 
            this.mainArrayBox.Location = new System.Drawing.Point(159, 360);
            this.mainArrayBox.Name = "mainArrayBox";
            this.mainArrayBox.Size = new System.Drawing.Size(502, 22);
            this.mainArrayBox.TabIndex = 36;
            // 
            // YourListLabel
            // 
            this.YourListLabel.AutoSize = true;
            this.YourListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourListLabel.Location = new System.Drawing.Point(155, 432);
            this.YourListLabel.Name = "YourListLabel";
            this.YourListLabel.Size = new System.Drawing.Size(91, 24);
            this.YourListLabel.TabIndex = 35;
            this.YourListLabel.Text = "Your list:";
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListLabel.Location = new System.Drawing.Point(155, 466);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(167, 24);
            this.ListLabel.TabIndex = 34;
            this.ListLabel.Text = "Here must be list";
            // 
            // FilledLenghtButton
            // 
            this.FilledLenghtButton.BackColor = System.Drawing.Color.Bisque;
            this.FilledLenghtButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilledLenghtButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilledLenghtButton.Location = new System.Drawing.Point(524, 200);
            this.FilledLenghtButton.Name = "FilledLenghtButton";
            this.FilledLenghtButton.Size = new System.Drawing.Size(164, 61);
            this.FilledLenghtButton.TabIndex = 33;
            this.FilledLenghtButton.Text = "See number of elements";
            this.FilledLenghtButton.UseVisualStyleBackColor = false;
            this.FilledLenghtButton.Click += new System.EventHandler(this.FilledLenghtButton_Click);
            // 
            // GetElementButton
            // 
            this.GetElementButton.BackColor = System.Drawing.Color.Bisque;
            this.GetElementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetElementButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetElementButton.Location = new System.Drawing.Point(436, 120);
            this.GetElementButton.Name = "GetElementButton";
            this.GetElementButton.Size = new System.Drawing.Size(157, 61);
            this.GetElementButton.TabIndex = 32;
            this.GetElementButton.Text = "Get element on position";
            this.GetElementButton.UseVisualStyleBackColor = false;
            this.GetElementButton.Click += new System.EventHandler(this.GetElementButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Bisque;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(137, 200);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(145, 61);
            this.DeleteButton.TabIndex = 31;
            this.DeleteButton.Text = "Delete element";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FindPositionButton
            // 
            this.FindPositionButton.BackColor = System.Drawing.Color.Bisque;
            this.FindPositionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindPositionButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindPositionButton.Location = new System.Drawing.Point(325, 200);
            this.FindPositionButton.Name = "FindPositionButton";
            this.FindPositionButton.Size = new System.Drawing.Size(157, 61);
            this.FindPositionButton.TabIndex = 30;
            this.FindPositionButton.Text = "Find position of an element";
            this.FindPositionButton.UseVisualStyleBackColor = false;
            this.FindPositionButton.Click += new System.EventHandler(this.FindPositionButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Bisque;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(234, 120);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(145, 61);
            this.AddButton.TabIndex = 29;
            this.AddButton.Text = "Add element";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab_1_lineal.Properties.Resources.full1;
            this.pictureBox2.Location = new System.Drawing.Point(-22, 299);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(908, 92);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_1_lineal.Properties.Resources.full1;
            this.pictureBox1.Location = new System.Drawing.Point(-54, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 92);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(827, 605);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.NextAddButton);
            this.Controls.Add(this.mainArrayLabel);
            this.Controls.Add(this.mainArrayBox);
            this.Controls.Add(this.YourListLabel);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.FilledLenghtButton);
            this.Controls.Add(this.GetElementButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FindPositionButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button NextAddButton;
        private System.Windows.Forms.Label mainArrayLabel;
        private System.Windows.Forms.TextBox mainArrayBox;
        private System.Windows.Forms.Label YourListLabel;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Button FilledLenghtButton;
        private System.Windows.Forms.Button GetElementButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FindPositionButton;
        private System.Windows.Forms.Button AddButton;
    }
}