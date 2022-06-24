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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            Data();
            CreateTest();
            CreateTextQustion(listTests[NumberQuestion]._Question);
            EnableButton(Last, null);
        }
        int test = 1;
        int y = 30;
        int i = 0;
        int NumberQuestion = 1;
       
        ListTest listTest = new ListTest();
        List<ListTest> listTests = new List<ListTest>();
        List<string[]> UserAnswer = new List<string[]>();
        public void Data()
        {
            listTests = listTest.ReadModul();
        }
        void EnableButton(object sender, EventArgs e)
        {
            //if (NumberQuestion == 1)
            //    (sender is Last).Enabled = false;
            //else
            //    (sender as Button).Enabled = true;

            //if (NumberQuestion == listTests.Count)
            //    (sender as Button).Enabled = false;
            //else
            //    (sender as Button).Enabled = true;
        }
        private void CreateTextBox(int create, string text)
        {
            var TextBox = new TextBox()
            {
                Location = new System.Drawing.Point(50, 70 + y),
                Size = new Size(200, 20),
                AutoSize = true,
                Name = "Test" + i,
                Multiline = true,
                Text = text,
                ReadOnly = true
            };
            var Label = new Label()
            {
                Location = new System.Drawing.Point(30, 70 + y),
                Size = new Size(200, 20),
                Font = new System.Drawing.Font("Times New Roman", 12F),
                AutoSize = true,
                Text = Convert.ToString(test)
            };
            if(create == 1)
            {
                var RadioButton = new RadioButton()
                {
                    Location = new System.Drawing.Point(15, 72 + y),
                    AutoSize = true,
                    Name = "RadioButton" + i
                };
                i++;
                groupBox2.Controls.Add(RadioButton);
            }
            if (create == 2)
            {
                var CheckBox = new CheckBox()
                {
                    Location = new System.Drawing.Point(15, 72 + y),
                    AutoSize = true,
                    Name = "CheckBox" + i
                };
                i++;
                groupBox2.Controls.Add(CheckBox);
            }
            if (create == 0)
            {
                TextBox.Size = new Size(400, 100);
                TextBox.ReadOnly = false;
                TextBox.Text = "";
            }
            groupBox2.Controls.Add(TextBox);
            groupBox2.Controls.Add(Label);
            test += 1;
            y += 30;
        }
        private string[] FillTrueAnswer(string param)
        {
            int k = 0;
            string[] TrueAnswer = new string[] { };
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {

                if (groupBox2.Controls[param + i] is RadioButton)
                {
                    if ((groupBox2.Controls[param + i] as RadioButton).Checked == true)
                    {
                        Array.Resize(ref TrueAnswer, TrueAnswer.Length + 1);
                        TrueAnswer[k] = (groupBox2.Controls["Test" + i] as TextBox).Text;
                        k++;
                    }
                }
                else if (groupBox2.Controls[param + i] is CheckBox)
                {
                    if ((groupBox2.Controls[param + i] as CheckBox).Checked == true)
                    {
                        Array.Resize(ref TrueAnswer, TrueAnswer.Length + 1);
                        TrueAnswer[k] = (groupBox2.Controls["Test" + i] as TextBox).Text;
                        k++;
                    }
                }
            }
            return TrueAnswer;
        }
        void CreateTextQustion(string text)
        {
            var TextBox = new TextBox()
            {
                Location = new System.Drawing.Point(75, 21),
                Multiline = true,
                Name = "Question",
                Text = text,
                ScrollBars = System.Windows.Forms.ScrollBars.Horizontal,
                Size = new System.Drawing.Size(300, 60)
            };
            var Label = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(10, 21),
                Text = "Питання"
            };
            groupBox2.Controls.Add(TextBox);
            groupBox2.Controls.Add(Label);
        }
        private void CreateTest()
        {
            groupBox2.Controls.Clear();
            test = 1;
            y = 30;
            i = 0;
            CreateTextQustion(listTests[NumberQuestion - 1]._Question);
            for (int i = 0; i < listTest.GiveCreateElement(NumberQuestion - 1 ); i++)
            {
                CreateTextBox(listTest.GiveAnswer(NumberQuestion - 1), listTests[NumberQuestion - 1]._Answer[i]);
            }
        }

        private void Last_Click(object sender, EventArgs e)
        {
            if (NumberQuestion != 1)
                NumberQuestion--;
            CreateTest();
            string param = ParamRadioCheck();
            UserAnswer.Add(FillTrueAnswer(param));
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (NumberQuestion != listTests.Count)
                NumberQuestion++;
            if (NumberQuestion == listTests.Count)
                Next.Enabled = false;
            CreateTest();
            string param = ParamRadioCheck();
            UserAnswer.Add(FillTrueAnswer(param));
        }

        private void AnswerSave_Click(object sender, EventArgs e)
        {
            string param = ParamRadioCheck();
            UserAnswer.Add(FillTrueAnswer(param));
        }
        string ParamRadioCheck() 
        {
            string param = "";
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                if ((groupBox2.Controls[i] as RadioButton) != null)
                {
                    param = "RadioButton";
                    break;
                }
                if ((groupBox2.Controls[i] as CheckBox) != null)
                {
                    param = "CheckBox";
                    break;
                }
            }
            return param;
        }

        private void EndTest_Click(object sender, EventArgs e)
        {
            decimal Rating = 0;
            Rating = listTest.Cool(UserAnswer);
            MessageBox.Show($"Оценка - {Rating}");
        }
    }
}
