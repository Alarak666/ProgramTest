
namespace FormTest
{
    partial class TestCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Create = new System.Windows.Forms.Button();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(381, 371);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(98, 46);
            this.Create.TabIndex = 0;
            this.Create.Text = "Сохранить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(37, 77);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(240, 21);
            this.RB2.TabIndex = 2;
            this.RB2.TabStop = true;
            this.RB2.Text = "Декілька правильних відповідей";
            this.RB2.UseVisualStyleBackColor = true;
            this.RB2.CheckedChanged += new System.EventHandler(this.RB2_CheckedChanged);
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Location = new System.Drawing.Point(37, 114);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(132, 21);
            this.RB3.TabIndex = 1;
            this.RB3.TabStop = true;
            this.RB3.Text = "Відповідь слово";
            this.RB3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.RB3.UseVisualStyleBackColor = true;
            this.RB3.CheckedChanged += new System.EventHandler(this.RB3_CheckedChanged);
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Location = new System.Drawing.Point(37, 21);
            this.RB1.MaximumSize = new System.Drawing.Size(200, 200);
            this.RB1.MinimumSize = new System.Drawing.Size(100, 50);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(200, 50);
            this.RB1.TabIndex = 0;
            this.RB1.TabStop = true;
            this.RB1.Text = "Тест з одною правильною відповідю";
            this.RB1.UseVisualStyleBackColor = true;
            this.RB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB2);
            this.groupBox1.Controls.Add(this.RB1);
            this.groupBox1.Controls.Add(this.RB3);
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибір тесту";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(381, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 338);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Завдання";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Создать файл ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Create);
            this.Name = "TestCreate";
            this.Text = "TestCreate";
            this.Load += new System.EventHandler(this.TestCreate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}