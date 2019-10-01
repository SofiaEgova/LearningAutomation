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
    public partial class FormTest : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly LearningAutomationDbContext _context;

        private Guid? _id;
        private Guid _materialId;
        private int countOfQuestions = 0;

        public FormTest(LearningAutomationDbContext context, Guid materialId, Guid? id = null)
        {
            InitializeComponent();
            _context = context;
            _id = id;
            _materialId = materialId;
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            if (_id != null)
            {
                var test = _context.Tests.FirstOrDefault(t => t.TestId == _id);
                textBoxTestName.Text = test.Title;
            }
            else
            {
                textBoxQuestion.Enabled = false;
                textBoxAnswer1.Enabled = false;
                textBoxAnswer2.Enabled = false;
                textBoxAnswer3.Enabled = false;
                textBoxAnswer4.Enabled = false;
                textBoxAllQuestions.Enabled = false;
            }
        }

        private bool checkQuestion()
        {
            if (string.IsNullOrEmpty(textBoxQuestion.Text)) return false;
            if (string.IsNullOrEmpty(textBoxAnswer1.Text)) return false;
            if (string.IsNullOrEmpty(textBoxAnswer2.Text)) return false;
            if (string.IsNullOrEmpty(textBoxAnswer3.Text)) return false;
            if (string.IsNullOrEmpty(textBoxAnswer4.Text)) return false;
            return true;

        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            if (checkQuestion())
            {
                countOfQuestions++;
                _context.Questions.Add(new Question { QuestionId = Guid.NewGuid(), TestId = (Guid)_id, Title = textBoxQuestion.Text, Answer1 = textBoxAnswer1.Text, Answer2 = textBoxAnswer2.Text, Answer3 = textBoxAnswer3.Text, Answer4 = textBoxAnswer4.Text });
                textBoxAllQuestions.AppendText(countOfQuestions + ") " + textBoxQuestion.Text + "\r\n");
                _context.SaveChanges();
                textBoxQuestion.Clear();
                textBoxAnswer1.Clear();
                textBoxAnswer2.Clear();
                textBoxAnswer3.Clear();
                textBoxAnswer4.Clear();
            }
            else
            {
                // сообщение об ошибке
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // проверить на пустоту
            if (_id == null)
            {
                textBoxQuestion.Enabled = true;
                textBoxAnswer1.Enabled = true;
                textBoxAnswer2.Enabled = true;
                textBoxAnswer3.Enabled = true;
                textBoxAnswer4.Enabled = true;
                _id = Guid.NewGuid();
                _context.Tests.Add(new Test { TestId = (Guid)_id, Title = textBoxTestName.Text, LearningMaterialId=_materialId });
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    
    }
}
