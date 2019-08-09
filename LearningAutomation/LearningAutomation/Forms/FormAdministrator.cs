using LearningAutomation.Model;
using LearningAutomation.Service;
using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Resolution;

namespace LearningAutomation.Forms
{
    public partial class FormAdministrator : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly LearningAutomationDbContext _context;

        public FormAdministrator(LearningAutomationDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        //добавление материала
        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            myStream = openFileDialog.OpenFile();

            byte[] buf = new byte[myStream.Length];

            myStream.Read(buf, 0, (int)myStream.Length);
            myStream.Close();

            _context.LearningMaterials.Add(new LearningMaterial { LearningMaterialId = new Guid(), File = buf });
            _context.SaveChanges();

        }
        //открытие материала
        private void button2_Click(object sender, EventArgs e)
        {
            var b = _context.LearningMaterials.FirstOrDefault();

            FileStream f;
            using (f = File.Create("file.pdf"))
            {
                {
                    f.Write(b.File, 0, b.File.Length);
                }
            }

            System.Diagnostics.Process.Start("file.pdf");
            //webBrowser1.Url = new Uri("file.pdf");
        }

        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            List<ColumnConfig> columns = new List<ColumnConfig>
            {
                new ColumnConfig { Name = "Id", Title = "Id", Width = 100, Visible = false },
                new ColumnConfig { Name = "Login", Title = "Логин", Width = 200, Visible = true },
                new ColumnConfig { Name = "Password", Title = "Пароль", Width = 300, Visible = true }
            };
            dataGridViewUsers.Columns.Clear();
            foreach (var column in columns)
            {
                dataGridViewUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = column.Title,
                    Name = string.Format("Column{0}", column.Name),
                    ReadOnly = true,
                    Visible = column.Visible,
                    Width = column.Width ?? 0,
                    AutoSizeMode = column.Width.HasValue ? DataGridViewAutoSizeColumnMode.None : DataGridViewAutoSizeColumnMode.Fill
                });
            }

            columns = new List<ColumnConfig>
            {
                new ColumnConfig { Name = "Id", Title = "Id", Width = 100, Visible = false },
                new ColumnConfig { Name = "Title", Title = "Заголовок", Width = 200, Visible = true },
                new ColumnConfig { Name = "CountOfTests", Title = "Кол-во тестов", Width = 300, Visible = true }
            };
            dataGridViewMaterials.Columns.Clear();
            foreach (var column in columns)
            {
                dataGridViewMaterials.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = column.Title,
                    Name = string.Format("Column{0}", column.Name),
                    ReadOnly = true,
                    Visible = column.Visible,
                    Width = column.Width ?? 0,
                    AutoSizeMode = column.Width.HasValue ? DataGridViewAutoSizeColumnMode.None : DataGridViewAutoSizeColumnMode.Fill
                });
            }

            LoadData();
        }

        private void LoadData()
        {
            var users = _context.Users.ToArray();
            (tabControl.TabPages[0].Controls["dataGridViewUsers"] as DataGridView).Rows.Clear();
            foreach (var u in users)
            {
                (tabControl.TabPages[0].Controls["dataGridViewUsers"] as DataGridView).Rows.Add(new object[]
                {
                    u.UserId,
                    u.Login,
                    u.Password
                });
            }

            var lmaterials = _context.LearningMaterials.ToArray();
            ///везде проверки на нулл

            (tabControl.TabPages[1].Controls["dataGridViewMaterials"] as DataGridView).Rows.Clear();
            foreach (var lm in lmaterials)
            {
                int countTests = (lm.Tests == null) ? 0 : lm.Tests.Count;
                (tabControl.TabPages[1].Controls["dataGridViewMaterials"] as DataGridView).Rows.Add(new object[]
                {
                    lm.LearningMaterialId,
                    lm.Title,
                    countTests
                });
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormUser>();
            form.ShowDialog();
        }

        private void buttonUpdUser_Click(object sender, EventArgs e)
        {
            /// проверить на наличие нажатия
            var id = dataGridViewUsers.SelectedCells[0];
            var form = Container.Resolve<FormUser>(
                        new ParameterOverrides
                        {
                            { "id", (Guid)id.Value }
                        }
                        .OnType<FormUser>());
            form.ShowDialog();
        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {
            /// проверить на наличие нажатия
            var id = dataGridViewUsers.SelectedCells[0];
            var user = _context.Users.Find((Guid)id.Value);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            myStream = openFileDialog.OpenFile();

            byte[] buf = new byte[myStream.Length];

            myStream.Read(buf, 0, (int)myStream.Length);
            myStream.Close();

            _context.LearningMaterials.Add(new LearningMaterial { LearningMaterialId = new Guid(), File = buf, Title = "test" });
            _context.SaveChanges();
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            var id = dataGridViewMaterials.SelectedCells[0];
            var form = Container.Resolve<FormMaterial>(
                        new ParameterOverrides
                        {
                            { "id", (Guid)id.Value }
                        }
                        .OnType<FormMaterial>()); 
            form.ShowDialog();
        }
    }
}
