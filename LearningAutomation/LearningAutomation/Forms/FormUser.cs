using LearningAutomation.Model;
using LearningAutomation.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace LearningAutomation.Forms
{
    public partial class FormUser : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly LearningAutomationDbContext _context;

        private Guid? _id = null;

        public FormUser(LearningAutomationDbContext context, Guid? id = null)
        {
            InitializeComponent();
            _context = context;

            if (id != Guid.Empty)
            {
                _id = id;
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            var result = _context.Users.FirstOrDefault(u => u.UserId == _id);
            if (result==null)
            {
                //Program.PrintErrorMessage("При загрузке возникла ошибка: ", result.Errors);
                Close();

            }
            var user = (User)result;

            textBoxLogin.Text = user.Login;
            textBoxPassword.Text = user.Password;
        }

        private bool CheckFill()
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text) && textBoxPassword.Enabled)
            {
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (CheckFill()) {
                if (_id.HasValue)
                {
                    var entity = _context.Users.FirstOrDefault(u => u.UserId == _id);
                    entity.Login = textBoxLogin.Text;
                    entity.Password = textBoxPassword.Text;
                }
                else _context.Users.Add(new User { UserId = Guid.NewGuid(), Login = textBoxLogin.Text, Password = textBoxPassword.Text });

                _context.SaveChanges();
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
