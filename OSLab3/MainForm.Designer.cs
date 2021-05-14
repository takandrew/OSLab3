
namespace OSLab3
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.PagesTextBox = new System.Windows.Forms.TextBox();
            this.FIFOTextBox = new System.Windows.Forms.RichTextBox();
            this.LRUTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Содержимое памяти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Содержимое обращений";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(571, 106);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(204, 22);
            this.MemoryTextBox.TabIndex = 4;
            this.MemoryTextBox.Text = "8 2 9 6 -1";
            // 
            // PagesTextBox
            // 
            this.PagesTextBox.Location = new System.Drawing.Point(571, 179);
            this.PagesTextBox.Name = "PagesTextBox";
            this.PagesTextBox.Size = new System.Drawing.Size(204, 22);
            this.PagesTextBox.TabIndex = 5;
            this.PagesTextBox.Text = "7 8 9 2 1 0 8 9 2 4 6 8 2 1 8 9";
            // 
            // FIFOTextBox
            // 
            this.FIFOTextBox.Location = new System.Drawing.Point(12, 43);
            this.FIFOTextBox.Name = "FIFOTextBox";
            this.FIFOTextBox.Size = new System.Drawing.Size(535, 403);
            this.FIFOTextBox.TabIndex = 6;
            this.FIFOTextBox.Text = "";
            // 
            // LRUTextBox
            // 
            this.LRUTextBox.Location = new System.Drawing.Point(805, 43);
            this.LRUTextBox.Name = "LRUTextBox";
            this.LRUTextBox.Size = new System.Drawing.Size(521, 403);
            this.LRUTextBox.TabIndex = 7;
            this.LRUTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "FIFO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1035, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "LRU";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(599, 240);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 62);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Запуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 466);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LRUTextBox);
            this.Controls.Add(this.FIFOTextBox);
            this.Controls.Add(this.PagesTextBox);
            this.Controls.Add(this.MemoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Алгоритмы выталкивания памяти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.TextBox PagesTextBox;
        private System.Windows.Forms.RichTextBox FIFOTextBox;
        private System.Windows.Forms.RichTextBox LRUTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartButton;
    }
}

