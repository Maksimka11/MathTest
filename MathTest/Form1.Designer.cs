namespace MathTest
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
            this.tbQuest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer4 = new System.Windows.Forms.RadioButton();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbQuest
            // 
            this.tbQuest.Location = new System.Drawing.Point(15, 25);
            this.tbQuest.Multiline = true;
            this.tbQuest.Name = "tbQuest";
            this.tbQuest.Size = new System.Drawing.Size(282, 103);
            this.tbQuest.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вопрос:";
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Location = new System.Drawing.Point(15, 145);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(85, 17);
            this.rbAnswer1.TabIndex = 2;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "radioButton1";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            this.rbAnswer1.CheckedChanged += new System.EventHandler(this.rbAnswer1_CheckedChanged);
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.Location = new System.Drawing.Point(15, 168);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(85, 17);
            this.rbAnswer2.TabIndex = 2;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "radioButton1";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            this.rbAnswer2.CheckedChanged += new System.EventHandler(this.rbAnswer2_CheckedChanged);
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.Location = new System.Drawing.Point(15, 191);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(85, 17);
            this.rbAnswer3.TabIndex = 2;
            this.rbAnswer3.TabStop = true;
            this.rbAnswer3.Text = "radioButton1";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            this.rbAnswer3.CheckedChanged += new System.EventHandler(this.rbAnswer3_CheckedChanged);
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.AutoSize = true;
            this.rbAnswer4.Location = new System.Drawing.Point(15, 214);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(85, 17);
            this.rbAnswer4.TabIndex = 2;
            this.rbAnswer4.TabStop = true;
            this.rbAnswer4.Text = "radioButton1";
            this.rbAnswer4.UseVisualStyleBackColor = true;
            this.rbAnswer4.CheckedChanged += new System.EventHandler(this.rbAnswer4_CheckedChanged);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(115, 248);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(262, 253);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(35, 13);
            this.lblQuestionNumber.TabIndex = 4;
            this.lblQuestionNumber.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 279);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.rbAnswer4);
            this.Controls.Add(this.rbAnswer3);
            this.Controls.Add(this.rbAnswer2);
            this.Controls.Add(this.rbAnswer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQuest);
            this.Name = "Form1";
            this.Text = "Тест по математике";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer4;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblQuestionNumber;
    }
}

