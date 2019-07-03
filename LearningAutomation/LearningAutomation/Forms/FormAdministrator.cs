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

        private void button1_Click(object sender, EventArgs e)
        {
            //Stream myStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            //myStream = openFileDialog..OpenFile();

            SautinSoft.PdfFocus pf = new SautinSoft.PdfFocus();
            pf.OpenPdf(openFileDialog.FileName);

            if (pf.PageCount > 0)
            {
                pf.ImageOptions.Dpi = 300;
                _context.LearningMaterials.Add(new LearningMaterial { LearningMaterialId = new Guid(), File = pf.ToMultipageTiff() });
                _context.SaveChanges();
                pf.ToMultipageTiff(@"d:\res.tiff");
            }

            //byte[] buf = new byte[myStream.Length];

            //myStream.Read(buf, 0, (int)myStream.Length);
            //myStream.Close();

            //_context.LearningMaterials.Add(new LearningMaterial { LearningMaterialId = new Guid(), File = buf });
            //_context.SaveChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
