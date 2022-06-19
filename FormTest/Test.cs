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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controls.Add(PCreate());
            CreateElement();
        }
        Panel panel;
        RadioButton radioButton;
        TextBox textBox;
        private RadioButton CreateRadioButton(int size)
        {
            var RadioButton = new RadioButton()
            {
                Location = new System.Drawing.Point(20, 20 + size),
                AutoSize = true,
                Text = "sdsds",
                BackColor = Color.Pink
            };
            return RadioButton;
        }
        private void CreateElement()
        {
            List<object> list = new List<object>();
            int size = 0;
            for (int i = 0; i < 5; i++)
            {
                list.Add(CreateRadioButton(i * 20));
                this.panel.Controls.Add((list[i] as RadioButton));
            }
        }
        private Panel PCreate()
        {
            panel = new Panel()
            {
                Location = new System.Drawing.Point(377, 17),
                Size = new System.Drawing.Size(358, 227),
                AutoSize = true,
                Visible = true,
                BackColor = Color.Red
            };
            return panel;
        }
    }
}
