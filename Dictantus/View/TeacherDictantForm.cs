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
    public partial class TeacherDictantForm : Form
    {
        public TeacherDictantForm()
        {
            InitializeComponent();
        }
        public TeacherDictantForm(Dictant dictant,ChoiseTeacherForm previousForm)
        {

            previousForm.Dispose();
            InitializeComponent();
            new TeacherDictantPresenter().Init(this, new TeacherDictantModel(dictant));
        }
        public event Action<List<int>, List<string>, string, string> SaveDictant;
        public event Action BackToTeachChoise;
        private void redOnBtn_Click(object sender, EventArgs e)
        {
            if (teacherBox.SelectionLength != 0)
            {
                teacherBox.SelectionBackColor = Color.Red;
            }
        }

        private void redOffBtn_Click(object sender, EventArgs e)
        {
            if (teacherBox.SelectionLength != 0)
            {
                teacherBox.SelectionBackColor = Color.White;
            }
        }

        private void teacherBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            teacherBox.SelectionBackColor = Color.White;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            List<int> positions = new List<int>();
            List<string> letters = new List<string>();
            for (int i = 0; i < teacherBox.Text.Length; i++)
            {
                teacherBox.Select(i, 1);
                if (teacherBox.SelectionBackColor == Color.Red)
                {
                    positions.Add(i);
                    letters.Add(teacherBox.SelectedText);
                }
            }
            for (int i = positions.Count - 1; i > 0; i--)
            {
                if (positions[i] - positions[i - 1] == 1)
                {
                    letters[i - 1] += letters[i];
                    positions.RemoveAt(i);
                    letters.RemoveAt(i);
                }
            }
            if (headerBox.Text == "") { MessageBox.Show("Пожалуйста, добавьте заголовок диктанта.", "Заголовок отсутсвует", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (teacherBox.Text == "") { MessageBox.Show("Пожалуйста, добавьте текст диктанта.", "Отсутствует текст диктанта", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (positions.Count == 0) { MessageBox.Show("Пожалуйста, добавьте ошибки","Отсутствуют ошибки",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
            else SaveDictant(positions, letters, teacherBox.Text, headerBox.Text);
        }
        public void fillTheField(List<int> positions, List<string> answers, string text, string header)
        {
            headerBox.Text = header;
            teacherBox.Text = text;
            for (int i = 0; i < positions.Count; i++)
            {
                teacherBox.Select(positions[i], answers[i].Length);
                teacherBox.SelectionBackColor = Color.Red;
            }
            teacherBox.Select(0, 0);

        }
        private void backToChoiseBtn_Click(object sender, EventArgs e)
        {
            BackToTeachChoise();
        }
        public void unbindingFromClosing()
        {
            FormClosing -= TeacherDictantForm_FormClosing;
        }
        private void TeacherDictantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть диктант?\nВсе несохраненные данные будут потеряны", "Обучающий диктант", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
