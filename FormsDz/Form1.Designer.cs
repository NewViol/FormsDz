
namespace FormsDz
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.ReductButt = new System.Windows.Forms.Button();
            this.DownloadButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(-3, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(564, 235);
            this.textBox.TabIndex = 0;
            // 
            // ReductButt
            // 
            this.ReductButt.Enabled = false;
            this.ReductButt.Location = new System.Drawing.Point(349, 258);
            this.ReductButt.Name = "ReductButt";
            this.ReductButt.Size = new System.Drawing.Size(164, 32);
            this.ReductButt.TabIndex = 1;
            this.ReductButt.Text = "Редактировать";
            this.ReductButt.UseVisualStyleBackColor = true;
            this.ReductButt.Click += new System.EventHandler(this.ReductButt_Click);
            // 
            // DownloadButt
            // 
            this.DownloadButt.Location = new System.Drawing.Point(55, 258);
            this.DownloadButt.Name = "DownloadButt";
            this.DownloadButt.Size = new System.Drawing.Size(164, 32);
            this.DownloadButt.TabIndex = 2;
            this.DownloadButt.Text = "Загрузить файл";
            this.DownloadButt.UseVisualStyleBackColor = true;
            this.DownloadButt.Click += new System.EventHandler(this.DownloadButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 332);
            this.Controls.Add(this.DownloadButt);
            this.Controls.Add(this.ReductButt);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "цвф";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button ReductButt;
        private System.Windows.Forms.Button DownloadButt;
    }
}

