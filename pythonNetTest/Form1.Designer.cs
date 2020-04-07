namespace pythonNetTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
         this.Test = new System.Windows.Forms.Button();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // Test
         // 
         this.Test.Location = new System.Drawing.Point(46, 383);
         this.Test.Name = "Test";
         this.Test.Size = new System.Drawing.Size(75, 23);
         this.Test.TabIndex = 0;
         this.Test.Text = "Sum";
         this.Test.UseVisualStyleBackColor = true;
         this.Test.Click += new System.EventHandler(this.Button1_Click);
         // 
         // richTextBox1
         // 
         this.richTextBox1.Location = new System.Drawing.Point(46, 44);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.Size = new System.Drawing.Size(526, 311);
         this.richTextBox1.TabIndex = 1;
         this.richTextBox1.Text = "";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(165, 384);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(43, 21);
         this.textBox1.TabIndex = 2;
         this.textBox1.Text = "2";
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(260, 384);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(43, 21);
         this.textBox2.TabIndex = 3;
         this.textBox2.Text = "3";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(228, 389);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(11, 12);
         this.label1.TabIndex = 4;
         this.label1.Text = "+";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(44, 18);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(94, 12);
         this.label2.TabIndex = 4;
         this.label2.Text = "Python sysPath";
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(354, 384);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(100, 21);
         this.textBox3.TabIndex = 5;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(320, 389);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(11, 12);
         this.label3.TabIndex = 4;
         this.label3.Text = "=";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(46, 415);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 6;
         this.button1.Text = "plot Show";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click_1);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(680, 450);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.richTextBox1);
         this.Controls.Add(this.Test);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button button1;
   }
}

