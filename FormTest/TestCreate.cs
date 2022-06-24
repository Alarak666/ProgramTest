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
        int i = 0;
        ListTest listTest = new ListTest();
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
                Name = "Test" + i,
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
                    AutoSize = true,
                    Name = "RadioButton" + i
                };
                i++;
                groupBox2.Controls.Add(RadioButton);
            }
            if (RB2.Checked == true)
            {
                var CheckBox = new CheckBox()
                {
                    Location = new System.Drawing.Point(15, 52 + y),
                    AutoSize = true,
                    Name = "CheckBox" + i
                };
                i++;
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
        private void CreateFormRB3()
        {
            var TextBox = new TextBox()
            {
                Location = new System.Drawing.Point(50, 70 + y),
                Size = new Size(200, 100),
                AutoSize = true,
                Name = "Test",
                Multiline = true,
                Text = ""
            };
            var Label = new Label()
            {
                Location = new System.Drawing.Point(50, 50 + y),
                Size = new Size(10, 20),
                AutoSize = true,
                Text = "Ответ"
            };
            CreateTextQustion();
            groupBox2.Controls.AddRange(new Control[] {TextBox, Label});
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            if (RB1.Checked == true || RB2.Checked == true)
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
            i = 0;
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
            string param = "";
            int k = 0;
            var Question = groupBox2.Controls.Find("Question", true); //Вопрос
            string[] Answer = new string[] { };//Ответы
            string[] TrueAnswer; // Правильний ответ
            if (RB3.Checked == true)
            {
                Array.Resize(ref Answer, Answer.Length + 1);
                Answer[0] = (groupBox2.Controls["Test"] as TextBox).Text;
                TrueAnswer = new string[1] {""};
            }
            else
            {
             
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
                TrueAnswer = FillTrueAnswer(param);
                for (int i = 0; i < groupBox2.Controls.Count; i++)
                {
                    if ((groupBox2.Controls["Test" + i] as TextBox) != null)
                    {
                        Array.Resize(ref Answer, Answer.Length + 1);
                        Answer[Answer.Length - 1] = (groupBox2.Controls["Test" + i] as TextBox).Text;
                        k++;
                    }
                }
            }
            
           
           listTest.Add(Question[0].Text, Answer, TrueAnswer);
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
                else if(groupBox2.Controls[param + i] is CheckBox)
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

        private void button1_Click(object sender, EventArgs e)
        {
            listTest.WriteModul();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    listTest.ReadModul();
        //}
    }
}
