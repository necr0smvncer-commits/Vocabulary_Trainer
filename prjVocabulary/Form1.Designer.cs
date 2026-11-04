namespace prjVocabulary
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
            this.ofdVocabulary = new System.Windows.Forms.OpenFileDialog();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnChooseTheVocab = new System.Windows.Forms.Button();
            this.lblChosen = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.chbInfinityMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ofdVocabulary
            // 
            this.ofdVocabulary.DefaultExt = "json";
            this.ofdVocabulary.Filter = "JSON Files|*.json";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(75, 70);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 13);
            this.lblWord.TabIndex = 0;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(75, 139);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 1;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitel.Location = new System.Drawing.Point(74, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(188, 24);
            this.lblTitel.TabIndex = 2;
            this.lblTitel.Text = "Vocabulary Trainer";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 308);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(302, 30);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnChooseTheVocab
            // 
            this.btnChooseTheVocab.Location = new System.Drawing.Point(16, 238);
            this.btnChooseTheVocab.Name = "btnChooseTheVocab";
            this.btnChooseTheVocab.Size = new System.Drawing.Size(302, 30);
            this.btnChooseTheVocab.TabIndex = 4;
            this.btnChooseTheVocab.Text = "Choose the vocabulary";
            this.btnChooseTheVocab.UseVisualStyleBackColor = true;
            this.btnChooseTheVocab.Click += new System.EventHandler(this.btnChooseTheVocab_Click);
            // 
            // lblChosen
            // 
            this.lblChosen.AutoSize = true;
            this.lblChosen.Location = new System.Drawing.Point(16, 275);
            this.lblChosen.Name = "lblChosen";
            this.lblChosen.Size = new System.Drawing.Size(0, 13);
            this.lblChosen.TabIndex = 5;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(78, 98);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(176, 20);
            this.txtWord.TabIndex = 6;
            // 
            // chbInfinityMode
            // 
            this.chbInfinityMode.AutoSize = true;
            this.chbInfinityMode.Location = new System.Drawing.Point(19, 215);
            this.chbInfinityMode.Name = "chbInfinityMode";
            this.chbInfinityMode.Size = new System.Drawing.Size(86, 17);
            this.chbInfinityMode.TabIndex = 7;
            this.chbInfinityMode.Text = "Infinity Mode";
            this.chbInfinityMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 345);
            this.Controls.Add(this.chbInfinityMode);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblChosen);
            this.Controls.Add(this.btnChooseTheVocab);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblWord);
            this.Name = "Form1";
            this.Text = "Vocabulary Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdVocabulary;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnChooseTheVocab;
        private System.Windows.Forms.Label lblChosen;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.CheckBox chbInfinityMode;
    }
}

