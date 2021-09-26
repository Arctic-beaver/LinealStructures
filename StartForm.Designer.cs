
namespace Lab_1_lineal
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.ListButton = new System.Windows.Forms.Button();
            this.ArrayButton = new System.Windows.Forms.Button();
            this.StackButton = new System.Windows.Forms.Button();
            this.InfixPostfixButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListButton
            // 
            this.ListButton.BackColor = System.Drawing.Color.Bisque;
            this.ListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListButton.Location = new System.Drawing.Point(129, 96);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(127, 61);
            this.ListButton.TabIndex = 0;
            this.ListButton.Text = "List";
            this.ListButton.UseVisualStyleBackColor = false;
            this.ListButton.Click += new System.EventHandler(this.List_Click);
            // 
            // ArrayButton
            // 
            this.ArrayButton.BackColor = System.Drawing.Color.Bisque;
            this.ArrayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArrayButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayButton.Location = new System.Drawing.Point(335, 96);
            this.ArrayButton.Name = "ArrayButton";
            this.ArrayButton.Size = new System.Drawing.Size(127, 61);
            this.ArrayButton.TabIndex = 1;
            this.ArrayButton.Text = "Array";
            this.ArrayButton.UseVisualStyleBackColor = false;
            this.ArrayButton.Click += new System.EventHandler(this.Array_Click);
            // 
            // StackButton
            // 
            this.StackButton.BackColor = System.Drawing.Color.Bisque;
            this.StackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StackButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StackButton.Location = new System.Drawing.Point(547, 96);
            this.StackButton.Name = "StackButton";
            this.StackButton.Size = new System.Drawing.Size(127, 61);
            this.StackButton.TabIndex = 2;
            this.StackButton.Text = "Stack";
            this.StackButton.UseVisualStyleBackColor = false;
            this.StackButton.Click += new System.EventHandler(this.Stack_Click);
            // 
            // InfixPostfixButton
            // 
            this.InfixPostfixButton.BackColor = System.Drawing.Color.Bisque;
            this.InfixPostfixButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfixPostfixButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfixPostfixButton.Location = new System.Drawing.Point(282, 313);
            this.InfixPostfixButton.Name = "InfixPostfixButton";
            this.InfixPostfixButton.Size = new System.Drawing.Size(254, 61);
            this.InfixPostfixButton.TabIndex = 3;
            this.InfixPostfixButton.Text = "Infix->postfix";
            this.InfixPostfixButton.UseVisualStyleBackColor = false;
            this.InfixPostfixButton.Click += new System.EventHandler(this.InfixPostfixButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab_1_lineal.Properties.Resources.min_owl;
            this.pictureBox2.Location = new System.Drawing.Point(281, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 216);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_1_lineal.Properties.Resources.full1;
            this.pictureBox1.Location = new System.Drawing.Point(-78, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 92);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(342, 401);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(127, 37);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.InfixPostfixButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StackButton);
            this.Controls.Add(this.ArrayButton);
            this.Controls.Add(this.ListButton);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Button ArrayButton;
        private System.Windows.Forms.Button StackButton;
        private System.Windows.Forms.Button InfixPostfixButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ExitButton;
    }
}

