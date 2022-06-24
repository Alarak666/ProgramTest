using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void CreateTest_Click(object sender, EventArgs e)
        {
            TestCreate form = new TestCreate();
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test form = new Test();
            form.Show();
            Hide();
        }
    }
}
