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
    public partial class ChoiseStudentForm : Form
    {
        public ChoiseStudentForm(User currentUser)
        {
            InitializeComponent();
            new ChoiseStudentPresenter().Init(this, new ChoiseStudentModel(currentUser));
        }
        public ChoiseStudentForm(User currentUser,DictantStudentForm previousForm)
        {
            InitializeComponent();
            previousForm.Dispose();
            new ChoiseStudentPresenter().Init(this, new ChoiseStudentModel(currentUser));
        }
        public event Action<Dictant> choiseTheDictant;
        public void showHeadersDictants(List<Dictant> dictantList)
        {
            dictantBindingSource.DataSource = dictantList;
        }

        /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            choiseTheDictant((Dictant)dictantBindingSource.Current);
        }*/

        

        private void choiseDictant_Click(object sender, EventArgs e)
        {
            if (dictantBindingSource.Current != null) choiseTheDictant((Dictant)dictantBindingSource.Current);
            else MessageBox.Show("Пожалуйста, выберите диктант");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            choiseTheDictant((Dictant)dictantBindingSource.Current);
        }
    }
}
