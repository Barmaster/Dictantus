namespace Dictantus
{
    partial class DictantStudentForm
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
            this.backToChoiseBtn = new System.Windows.Forms.Button();
            this.StatisticLabel = new System.Windows.Forms.Label();
            this.statlab = new System.Windows.Forms.Label();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.labelCorct = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.checkDictantBtn = new System.Windows.Forms.Button();
            this.studyBox = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.headerBox = new System.Windows.Forms.TextBox();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backToChoiseBtn
            // 
            this.backToChoiseBtn.BackgroundImage = global::Dictantus.Properties.Resources.BACK;
            this.backToChoiseBtn.Location = new System.Drawing.Point(28, 24);
            this.backToChoiseBtn.Name = "backToChoiseBtn";
            this.backToChoiseBtn.Size = new System.Drawing.Size(30, 30);
            this.backToChoiseBtn.TabIndex = 20;
            this.toolTip.SetToolTip(this.backToChoiseBtn, "Вернуться к выбору диктанта");
            this.backToChoiseBtn.UseVisualStyleBackColor = true;
            this.backToChoiseBtn.Click += new System.EventHandler(this.backToChoiseBtn_Click);
            // 
            // StatisticLabel
            // 
            this.StatisticLabel.AutoSize = true;
            this.StatisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticLabel.Location = new System.Drawing.Point(401, 572);
            this.StatisticLabel.Name = "StatisticLabel";
            this.StatisticLabel.Size = new System.Drawing.Size(40, 16);
            this.StatisticLabel.TabIndex = 19;
            this.StatisticLabel.Text = "55%";
            // 
            // statlab
            // 
            this.statlab.AutoSize = true;
            this.statlab.Location = new System.Drawing.Point(298, 575);
            this.statlab.Name = "statlab";
            this.statlab.Size = new System.Drawing.Size(97, 13);
            this.statlab.TabIndex = 18;
            this.statlab.Text = "Ваша статистика:";
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.wrongLabel);
            this.resultPanel.Controls.Add(this.correctLabel);
            this.resultPanel.Controls.Add(this.labelWrong);
            this.resultPanel.Controls.Add(this.labelCorct);
            this.resultPanel.Location = new System.Drawing.Point(562, 527);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(210, 63);
            this.resultPanel.TabIndex = 17;
            this.resultPanel.Visible = false;
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongLabel.Location = new System.Drawing.Point(147, 36);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(0, 16);
            this.wrongLabel.TabIndex = 3;
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctLabel.Location = new System.Drawing.Point(147, 8);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(0, 16);
            this.correctLabel.TabIndex = 2;
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Location = new System.Drawing.Point(13, 39);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(128, 13);
            this.labelWrong.TabIndex = 1;
            this.labelWrong.Text = "Неправильных ответов:";
            // 
            // labelCorct
            // 
            this.labelCorct.AutoSize = true;
            this.labelCorct.Location = new System.Drawing.Point(13, 11);
            this.labelCorct.Name = "labelCorct";
            this.labelCorct.Size = new System.Drawing.Size(116, 13);
            this.labelCorct.TabIndex = 0;
            this.labelCorct.Text = "Правильных ответов:";
            // 
            // restartBtn
            // 
            this.restartBtn.BackgroundImage = global::Dictantus.Properties.Resources.RSTART;
            this.restartBtn.Location = new System.Drawing.Point(80, 24);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(30, 30);
            this.restartBtn.TabIndex = 4;
            this.toolTip.SetToolTip(this.restartBtn, "Начать заново");
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // checkDictantBtn
            // 
            this.checkDictantBtn.Location = new System.Drawing.Point(334, 536);
            this.checkDictantBtn.Name = "checkDictantBtn";
            this.checkDictantBtn.Size = new System.Drawing.Size(75, 25);
            this.checkDictantBtn.TabIndex = 16;
            this.checkDictantBtn.Text = "Проверить";
            this.checkDictantBtn.UseVisualStyleBackColor = true;
            this.checkDictantBtn.Click += new System.EventHandler(this.checkDictantBtn_Click);
            // 
            // studyBox
            // 
            this.studyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.studyBox.Location = new System.Drawing.Point(12, 80);
            this.studyBox.Name = "studyBox";
            this.studyBox.ReadOnly = true;
            this.studyBox.Size = new System.Drawing.Size(760, 439);
            this.studyBox.TabIndex = 15;
            this.studyBox.Text = "";
            this.studyBox.VScroll += new System.EventHandler(this.studyBox_VScroll);
            this.studyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.studyBox_KeyDown);
            // 
            // headerBox
            // 
            this.headerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerBox.Location = new System.Drawing.Point(148, 21);
            this.headerBox.Multiline = true;
            this.headerBox.Name = "headerBox";
            this.headerBox.ReadOnly = true;
            this.headerBox.Size = new System.Drawing.Size(499, 35);
            this.headerBox.TabIndex = 21;
            // 
            // DictantStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 602);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.headerBox);
            this.Controls.Add(this.backToChoiseBtn);
            this.Controls.Add(this.StatisticLabel);
            this.Controls.Add(this.statlab);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.checkDictantBtn);
            this.Controls.Add(this.studyBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DictantStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение диктанта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DictantStudentForm_FormClosing);
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToChoiseBtn;
        private System.Windows.Forms.Label StatisticLabel;
        private System.Windows.Forms.Label statlab;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label wrongLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label labelCorct;
        private System.Windows.Forms.Button checkDictantBtn;
        private System.Windows.Forms.RichTextBox studyBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolTip toolTipForAnswers;
        private System.Windows.Forms.TextBox headerBox;
    }
}