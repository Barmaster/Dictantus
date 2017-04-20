using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictantus
{
    public partial class AuthorizationForm : Form
    {

        public AuthorizationForm()
        {
            InitializeComponent();
            new AuthorizationPresenter().Init(this, new AuthorizationModel());
        }

        public event Action<string, string> trySignIn;

        private void signInButton_Click(object sender, EventArgs e)
        {
            trySignIn(loginField.Text, parolField.Text);
        }

        public void wrongLoginOrPassword()
        {
            MessageBox.Show("Извините, к сожалению веденный пароль или логин не верен", "Не удалось выполнить вход");
        }

        private void AuthorizationForm_Shown(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Refresh();
            while (Opacity < 1)
            {
                this.Refresh();
                System.Threading.Thread.Sleep(5);
                Opacity += .01d;
            }
        }

        private void AuthorizationForm_Click(object sender, EventArgs e)
        {
           signInButton.Focus();
        }

        

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(asm.Location);
            MessageBox.Show(fvi.FileDescription+"\n\n"+fvi.CompanyName+"\n\n"+fvi.LegalCopyright+ "\n\nВерсия "+fvi.ProductVersion);
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обучающая система «Диктант» предназначена для проведения проверочных работ на знание орфографии русского языка в школьных учреждениях и индивидуальных занятий учеников.\n\n«Учитель» осуществляет создание новых диктантов, их сохранение, а так же редактирование существующих текстов.\n\n«Ученик» осуществляет выбор задания и его выполнение с получением резулататов выполнения.", "Просмотр задания", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void parolField_Enter(object sender, EventArgs e)
        {
            parolField.ForeColor = Color.Black;
            if (parolField.Text == "Пароль") { parolField.Text = ""; parolField.UseSystemPasswordChar = true; }
        }

        private void parolField_Leave(object sender, EventArgs e)
        {
            if (parolField.Text.Trim() == "")
            {
                parolField.UseSystemPasswordChar = false;
                parolField.Text = "Пароль";
                parolField.ForeColor = Color.LightGray;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text.Trim() == "")
            {
                loginField.Text = "Логин";
                loginField.ForeColor = Color.LightGray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            loginField.ForeColor = Color.Black;
            if (loginField.Text == "Логин") loginField.Text = "";
        }


        //private void prettyStart()
        //{
        //    Opacity = 0;
        //    Timer timer = new Timer();
        //    timer.Tick += new EventHandler((sender, e) =>
        //    {
        //        if ((Opacity += 0.01d) >= 1) timer.Stop();
        //    });
        //    timer.Interval = 5;
        //    timer.Start();
        //}
    }
}
