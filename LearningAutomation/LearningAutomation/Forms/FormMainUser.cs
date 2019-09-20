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
    public partial class FormMainUser : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly LearningAutomationDbContext _context;

        public FormMainUser(LearningAutomationDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {

        }

        private void FormMainUser_Load(object sender, EventArgs e)
        {
            List<ColumnConfig> columns = new List<ColumnConfig>
            {
                new ColumnConfig { Name = "Id", Title = "Id", Width = 100, Visible = false },
                new ColumnConfig { Name = "TestTitle", Title = "Заголовок", Width = 200, Visible = true },
                new ColumnConfig { Name = "Result", Title = "Результат", Width = 300, Visible = true }
            };
            dataGridViewStatistic.Columns.Clear();
            foreach (var column in columns)
            {
                dataGridViewStatistic.Columns.Add(new DataGridViewTextBoxColumn
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
                new ColumnConfig { Name = "CountOfTests", Title = "Кол-во тестов", Width = 300, Visible = true },
                 new ColumnConfig { Name = "isPassed", Title = "Сдано", Width = 300, Visible = true }
            };
            dataGridViewLearning.Columns.Clear();
            foreach (var column in columns)
            {
                dataGridViewLearning.Columns.Add(new DataGridViewTextBoxColumn
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
            var result=0; int countOfPassedTests=0;
            var user = _context.Users.FirstOrDefault(u => u.IsActive == true);
            var results = _context.Results.Where(r=>r.UserId==user.UserId);

            (tabControl.TabPages[0].Controls["dataGridViewStatistic"] as DataGridView).Rows.Clear();
            foreach (var r in results)
            {
                result += r.Score;
                countOfPassedTests++;
                var title = _context.Tests.FirstOrDefault(t => t.TestId == r.TestId).Title;
                (tabControl.TabPages[0].Controls["dataGridViewStatistic"] as DataGridView).Rows.Add(new object[]
                {
                    r.ResultId,
                    title,
                    r.Score
                });
            }
            textBoxResult.Text = result / countOfPassedTests+"";

            var lmaterials = _context.LearningMaterials.ToArray();
            ///везде проверки на нулл

            (tabControl.TabPages[0].Controls["dataGridViewLearning"] as DataGridView).Rows.Clear();
            foreach (var lm in lmaterials)
            {
                var isPassed = "нет";
                var testId = _context.Tests.FirstOrDefault(t => t.LearningMaterialId == lm.LearningMaterialId).TestId;
                var res = _context.Results.FirstOrDefault(r => r.TestId == testId);
                if (res != null) isPassed = "да";

                (tabControl.TabPages[0].Controls["dataGridViewLearning"] as DataGridView).Rows.Add(new object[]
                {
                    lm.LearningMaterialId,
                    lm.Title,
                    lm.Tests.Count,
                    isPassed
                });
            }
        }
    }
}
