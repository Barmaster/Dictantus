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
    public partial class ChoiseTeacherForm : Form
    {
        public ChoiseTeacherForm()
        {
            InitializeComponent();
            new ChoiseTeacherPresenter().Init(this, new ChoiseTeacherModel());
        }
        public ChoiseTeacherForm(TeacherDictantForm previousForm)
        {

            previousForm.Dispose();
            InitializeComponent();
            new ChoiseTeacherPresenter().Init(this, new ChoiseTeacherModel());
        }
        public event Action<Dictant> DeleteDictant;
        public event Action AddDictant;
        public event Action<Dictant> EditDictant;

        public void showHeadersDictants(List<Dictant> dictantList)
        {
            dictantBindingSource.DataSource = dictantList;
        }
        private void deleteStripLabel_Click(object sender, EventArgs e)
        {
             DeleteDictant((Dictant)dictantBindingSource.Current);
        }

        private void editStripLabel_Click(object sender, EventArgs e)
        {
            EditDictant((Dictant)dictantBindingSource.Current);
        }

        private void AddStripLabel_Click(object sender, EventArgs e)
        {
           AddDictant();
        }
    }
}
