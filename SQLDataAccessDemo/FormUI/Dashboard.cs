using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Student> students = new List<Student>();
        
        public Dashboard()
        {
            InitializeComponent();

            UpdatingBinding();
        }

        private void UpdatingBinding()
        {
            lstData.DataSource = students;
            lstData.DisplayMember = "FullInfo";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
             
            students = db.GetStudents(txtName.Text);

            lstData.DataSource = students;
            lstData.DisplayMember = "FullInfo";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
