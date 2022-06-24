
namespace FormTest
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateTest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTest
            // 
            this.CreateTest.Location = new System.Drawing.Point(316, 111);
            this.CreateTest.Name = "CreateTest";
            this.CreateTest.Size = new System.Drawing.Size(100, 45);
            this.CreateTest.TabIndex = 0;
            this.CreateTest.Text = "Создать тест";
            this.CreateTest.UseVisualStyleBackColor = true;
            this.CreateTest.Click += new System.EventHandler(this.CreateTest_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Список тестов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateTest);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateTest;
        private System.Windows.Forms.Button button2;
    }
}

