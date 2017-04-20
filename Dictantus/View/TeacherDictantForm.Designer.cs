namespace Dictantus
{
    partial class TeacherDictantForm
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
            this.headerlbl = new System.Windows.Forms.Label();
            this.headerBox = new System.Windows.Forms.TextBox();
            this.teacherBox = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.backToChoiseBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.redOffBtn = new System.Windows.Forms.Button();
            this.redOnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerlbl.Location = new System.Drawing.Point(314, 11);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(138, 16);
            this.headerlbl.TabIndex = 14;
            this.headerlbl.Text = "Название диктанта";
            // 
            // headerBox
            // 
            this.headerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerBox.Location = new System.Drawing.Point(138, 30);
            this.headerBox.Multiline = true;
            this.headerBox.Name = "headerBox";
            this.headerBox.Size = new System.Drawing.Size(499, 35);
            this.headerBox.TabIndex = 13;
            // 
            // teacherBox
            // 
            this.teacherBox.BackColor = System.Drawing.Color.White;
            this.teacherBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.teacherBox.Location = new System.Drawing.Point(12, 74);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.Size = new System.Drawing.Size(760, 516);
            this.teacherBox.TabIndex = 12;
            this.teacherBox.Text = "";
            // 
            // backToChoiseBtn
            // 
            this.backToChoiseBtn.BackgroundImage = global::Dictantus.Properties.Resources.BACK;
            this.backToChoiseBtn.Location = new System.Drawing.Point(66, 33);
            this.backToChoiseBtn.Name = "backToChoiseBtn";
            this.backToChoiseBtn.Size = new System.Drawing.Size(30, 30);
            this.backToChoiseBtn.TabIndex = 18;
            this.toolTip.SetToolTip(this.backToChoiseBtn, "Назад к диктантам");
            this.backToChoiseBtn.UseVisualStyleBackColor = true;
            this.backToChoiseBtn.Click += new System.EventHandler(this.backToChoiseBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = global::Dictantus.Properties.Resources.SAVE;
            this.saveBtn.Location = new System.Drawing.Point(102, 33);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(30, 30);
            this.saveBtn.TabIndex = 17;
            this.toolTip.SetToolTip(this.saveBtn, "Сохранить диктант");
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // redOffBtn
            // 
            this.redOffBtn.BackgroundImage = global::Dictantus.Properties.Resources.UNDIK;
            this.redOffBtn.Location = new System.Drawing.Point(679, 33);
            this.redOffBtn.Name = "redOffBtn";
            this.redOffBtn.Size = new System.Drawing.Size(30, 30);
            this.redOffBtn.TabIndex = 16;
            this.toolTip.SetToolTip(this.redOffBtn, "Убрать ошибку");
            this.redOffBtn.UseVisualStyleBackColor = true;
            this.redOffBtn.Click += new System.EventHandler(this.redOffBtn_Click);
            // 
            // redOnBtn
            // 
            this.redOnBtn.BackgroundImage = global::Dictantus.Properties.Resources.mlt_icons_копия;
            this.redOnBtn.Location = new System.Drawing.Point(643, 33);
            this.redOnBtn.Name = "redOnBtn";
            this.redOnBtn.Size = new System.Drawing.Size(30, 30);
            this.redOnBtn.TabIndex = 15;
            this.toolTip.SetToolTip(this.redOnBtn, "Отметить как ошибку");
            this.redOnBtn.UseVisualStyleBackColor = true;
            this.redOnBtn.Click += new System.EventHandler(this.redOnBtn_Click);
            // 
            // TeacherDictantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 602);
            this.Controls.Add(this.backToChoiseBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.redOffBtn);
            this.Controls.Add(this.redOnBtn);
            this.Controls.Add(this.headerlbl);
            this.Controls.Add(this.headerBox);
            this.Controls.Add(this.teacherBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TeacherDictantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование диктанта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherDictantForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToChoiseBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button redOffBtn;
        private System.Windows.Forms.Button redOnBtn;
        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.TextBox headerBox;
        private System.Windows.Forms.RichTextBox teacherBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}