using DictantusCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictantus
{
    public partial class DictantStudentForm : Form
    {
        public DictantStudentForm()
        {
            InitializeComponent();
        }
        public DictantStudentForm(Dictant dictant, User currentUser,ChoiseStudentForm previousForm)
        {
            InitializeComponent();
            previousForm.Dispose();
            new DictantStudentPresenter().Init(this, new DictantStudentModel(dictant, currentUser));
        }
        public event Action<List<string>> CheckDictant;
        public event Action BackToStChoise;
        public event Action RestartThisDictant;
        public void resultOfCheck(List<int> correctPos, double newStatistic, List<string> correctAnswers)
        {
            int wrong = 0;
            int i = 0;
            toolTipForAnswers = new ToolTip();
            foreach (object o in studyBox.Controls)
            {
                TextBox tb = (o as TextBox);
                tb.ReadOnly = true;
                if (correctPos.Contains(Int32.Parse(tb.Name)))
                {
                    tb.BackColor = Color.FromArgb(160,250,170);
                }
                else
                {
                    tb.BackColor = Color.FromArgb(255,175,175);
                    wrong++;
                    toolTipForAnswers.SetToolTip(tb,correctAnswers[i]);
                }
                i++;
            }
            correctLabel.Text = correctPos.Count.ToString();
            wrongLabel.Text = wrong.ToString();
            resultPanel.Visible = true;
            StatisticLabel.Text = newStatistic.ToString() + "%";
            StatisticLabel.Focus();
        }

        private void checkDictantBtn_Click(object sender, EventArgs e)
        {
            List<string> studentAnswers = new List<string>();
            foreach (object o in studyBox.Controls)
            {
                TextBox tb = (o as TextBox);
                studentAnswers.Add(tb.Text.ToLower());
            }
            CheckDictant(studentAnswers);
            checkDictantBtn.Visible = false;
        }

        private void studyBox_VScroll(object sender, EventArgs e)
        {
            foreach (object o in studyBox.Controls)
            {
                TextBox tb = (o as TextBox);
                Point location = studyBox.GetPositionFromCharIndex(Int32.Parse(tb.Name));
                tb.Location = new Point(location.X - 1, location.Y - 1);
            }
        }

        private void studyBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control) studyBox.Select(0, 0);
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            
            RestartThisDictant();
        }
        public void restartField()
        {
            resultPanel.Visible = false;
            foreach (object o in studyBox.Controls)
            {
                TextBox tb = (o as TextBox);
                tb.ReadOnly = false;
                tb.BackColor = Color.White;
                tb.Text = "";
            }
            if(toolTipForAnswers!=null)toolTipForAnswers.Dispose();
            checkDictantBtn.Visible = true;
        }
        public void setTextAndStatistic(string text, string header,List<int> positionList, List<string> answerList, double statistic)
        {
            headerBox.Text = header;
            StatisticLabel.Text = statistic.ToString() + "%";
            studyBox.Text = text;
            List<TextBox> tbList = new List<TextBox>();
            for (int i = 0; i < positionList.Count; i++)
            {
                tbList.Add(new TextBox());
                tbList[i].Multiline = true;

                tbList[i].KeyDown += (object sender, KeyEventArgs e) =>
                {
                    if (e.KeyCode == Keys.Right
                         && (sender as TextBox).SelectionStart == (sender as TextBox).Text.Length)
                        studyBox.SelectNextControl(sender as TextBox, true, false, false, false);
                    else if (e.KeyCode == Keys.Left
                         && (sender as TextBox).SelectionStart == 0)
                        studyBox.SelectNextControl(sender as TextBox, false, false, false, false);
                };
                #region
                //tbList[i].Font = new Font(studyBox.Font.FontFamily, 17f, GraphicsUnit.Pixel);
                //Size size = TextRenderer.MeasureText(answerList[i], studyBox.Font);
                //tbList[i].Size = new Size((int)size.Width - 10, (int)(studyBox.Font.Size * 1.34));
                #endregion
                tbList[i].Size = new Size((int)studyBox.Font.Size * answerList[i].Length + 2, (int)(studyBox.Font.Size * 1.34) + 1);
                tbList[i].Name = positionList[i].ToString();
                Point location = studyBox.GetPositionFromCharIndex(positionList[i]);
                tbList[i].Location = new Point(location.X - 1, location.Y - 1);
                studyBox.Controls.Add(tbList[i]);
            }
            StatisticLabel.Focus();

        }

        private void backToChoiseBtn_Click(object sender, EventArgs e)
        {
           
            BackToStChoise();
        }
        public void unbidingFromClosing()
        {

            FormClosing -= DictantStudentForm_FormClosing;
        }

        private void DictantStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Вы действительно хотите закрыть диктант?\nВсе несохраненные данные будут потеряны", "Обучающий диктант", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
