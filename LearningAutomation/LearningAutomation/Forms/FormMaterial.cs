using LearningAutomation.Service;
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
    public partial class FormMaterial : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly LearningAutomationDbContext _context;

        private Guid _id;

        public FormMaterial(LearningAutomationDbContext context, Guid id)
        {
            InitializeComponent();
            _context = context;
            _id = id;
        }

        private void FormMaterial_Load(object sender, EventArgs e)
        {
            var file = _context.LearningMaterials.FirstOrDefault(m => m.LearningMaterialId == _id);
            labelTitle.Text = file.Title;
        }

        private void buttonShow_Click(object sender, EventArgs e)
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

            // по закрытию файла удалять его!!
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            //var id = dataGridView1.SelectedCells[0]; изменить
            var form = Container.Resolve<FormTest>(
                        new ParameterOverrides
                        {
                            {"materialId", _id }
                        }
                        .OnType<FormTest>());
            form.ShowDialog();
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {

        }
    }
}
