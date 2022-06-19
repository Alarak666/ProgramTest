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
    public partial class TestCreate : Form
    {
        public TestCreate()
        {
            InitializeComponent();
        }
        int test = 1;
        int y = 30;
        private void TestCreate_Load(object sender, EventArgs e)
        {

        }
        
        private TextBox CreateTextBox()
        {
            var TextBox = new TextBox()
            {
                Location = new System.Drawing.Point(50, 50 + y),
                Size = new Size(200, 20),
                AutoSize = true,
                Name = "Test",
                Multiline = true,
                Text = ""
            };
            var Label = new Label()
            {
                Location = new System.Drawing.Point(30, 50 + y),
                Size = new Size(200, 20),
                Font = new System.Drawing.Font("Times New Roman", 12F),
                AutoSize = true,
                Text = Convert.ToString(test)
            };
            if (RB1.Checked == true)
            {
                var RadioButton = new RadioButton()
                {
                    Location = new System.Drawing.Point(15, 52 + y),
                    AutoSize = true
                };
                groupBox2.Controls.Add(RadioButton);
            }
            if (RB2.Checked == true)
            {
                var CheckBox = new CheckBox()
                {
                    Location = new System.Drawing.Point(15, 52 + y),
                    AutoSize = true
                };
                groupBox2.Controls.Add(CheckBox);
            }
            groupBox2.Controls.Add(Label);
                test += 1;
            y += 30;
            return TextBox;
        }
        void CreateTextQustion()
        {
            var TextBox = new TextBox()
            {
                Location = new System.Drawing.Point(158, 18),
                Multiline = true,
                Name = "Question",
                ScrollBars = System.Windows.Forms.ScrollBars.Horizontal,
                Size = new System.Drawing.Size(225, 53)
            };
            var Label = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(22, 21),
                Size = new System.Drawing.Size(130, 17),
                Text = "Название вопроса"
            };
            groupBox2.Controls.Add(TextBox);
            groupBox2.Controls.Add(Label);
        }
        CheckBox CreateCheckBox()
        {
            return new CheckBox();
        }
        private Button CreateFormRB1()
        {
            var Button = new Button()
            {
                Location = new System.Drawing.Point(50, 80 + y),
                AutoSize = true,
                Text = "+"
            };

            CreateTextQustion();
            Button.Click += ButtonClick;
            
            
            return Button;
        }
        private Button CreateFormRB3()
        {
            var Button = new Button()
            {
                Location = new System.Drawing.Point(50, 80 + y),
                AutoSize = true,
                Text = "+"
            };
            CreateTextQustion();
            Button.Click += ButtonClick;
            return Button;
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            if (RB1.Checked == true|| RB2.Checked == true)
            {
                Button oldbutton = (Button)sender;
                if (test < 8)
                {
                    groupBox2.Controls.Add(CreateTextBox());
                    oldbutton.Location = new Point(oldbutton.Location.X, oldbutton.Location.Y + 30);
                }
            }

        }
        void Clear()
        {
            test = 1;
             y = 30;
            groupBox2.Controls.Clear();
        }
        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            
            groupBox2.Controls.Add(CreateFormRB1());
            groupBox2.Controls.Add(CreateTextBox());
        }
        private void RB2_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            groupBox2.Controls.Add(CreateFormRB1());
            groupBox2.Controls.Add(CreateTextBox());
        }
        private void RB3_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            CreateFormRB3();
        }
        private void Create_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Find("Test", true);
            ListTest listTest = new ListTest();
            //listTest.Add();
        }
    }
}
