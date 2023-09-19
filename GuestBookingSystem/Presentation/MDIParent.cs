using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestBookingSystem.Presentation
{
    public partial class MDIParent : Form
    {

        #region Data Members
        private int childFormNumber = 0;
        private CreateCustomerForm createCustForm;
        private EditCustomerForm editCustomersForm;
        private MakeBookingForm makeBookingForm;
        private EditBookingForm editBookingForm;

        #endregion

        #region Constructor


        public MDIParent()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Events

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {

        }

        private void createACustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (createCustForm == null)
            {
                CreateCustomerForm();
            }
            else
                if (!createCustForm.IsOpen)
            {
                CreateCustomerForm();
            }

        }

        public void CreateCustomerForm()
        {

            //need to check this
            createCustForm = new CreateCustomerForm();
            createCustForm.MdiParent = this;
            createCustForm.Show();
        }



        private void editCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editCustomersForm == null)
            {
                EditCustomerForm();
            }
            else
                if (!editCustomersForm.IsOpen)
            {
                EditCustomerForm();
            }

        }

        public void EditCustomerForm()
        {
            editCustomersForm = new EditCustomerForm();
            editCustomersForm.MdiParent = this;
            editCustomersForm.Show();

        }

        public void MakeaBookingForm()
        {
            makeBookingForm = new MakeBookingForm();
            makeBookingForm.MdiParent = this;
            makeBookingForm.Show();
        }



        private void createABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (makeBookingForm == null)
            {
                MakeaBookingForm();
            }
            else
                if (!makeBookingForm.IsOpen)
            {
                MakeaBookingForm();
            }
        }

        private void editBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editBookingForm == null)
            {
                EditBookingForm();
            }
            else
                if (!editBookingForm.IsOpen)
            {
                EditBookingForm();
            }

        }

        private void EditBookingForm()
        {
            editBookingForm = new EditBookingForm();
            editBookingForm.MdiParent = this;
            editBookingForm.Show();
        }

        #endregion
    }
}
