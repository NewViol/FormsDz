
namespace FormsDz
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CencelButt = new System.Windows.Forms.Button();
            this.SaweButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-2, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 235);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CencelButt
            // 
            this.CencelButt.Location = new System.Drawing.Point(355, 263);
            this.CencelButt.Name = "CencelButt";
            this.CencelButt.Size = new System.Drawing.Size(164, 32);
            this.CencelButt.TabIndex = 2;
            this.CencelButt.Text = "Отмена";
            this.CencelButt.UseVisualStyleBackColor = true;
            this.CencelButt.Click += new System.EventHandler(this.CencelButt_Click);
            // 
            // SaweButt
            // 
            this.SaweButt.Location = new System.Drawing.Point(37, 263);
            this.SaweButt.Name = "SaweButt";
            this.SaweButt.Size = new System.Drawing.Size(164, 32);
            this.SaweButt.TabIndex = 3;
            this.SaweButt.Text = "Сохранить";
            this.SaweButt.UseVisualStyleBackColor = true;
            this.SaweButt.Click += new System.EventHandler(this.SaweButt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 332);
            this.Controls.Add(this.SaweButt);
            this.Controls.Add(this.CencelButt);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button CencelButt;
        private System.Windows.Forms.Button SaweButt;
    }
}