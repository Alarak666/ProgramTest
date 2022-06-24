
namespace FormTest
{
    partial class Test
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Next = new System.Windows.Forms.Button();
            this.AnswerSave = new System.Windows.Forms.Button();
            this.EndTest = new System.Windows.Forms.Button();
            this.Last = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 345);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тест";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(186, 363);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(94, 68);
            this.Next.TabIndex = 3;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // AnswerSave
            // 
            this.AnswerSave.Location = new System.Drawing.Point(286, 363);
            this.AnswerSave.Name = "AnswerSave";
            this.AnswerSave.Size = new System.Drawing.Size(95, 68);
            this.AnswerSave.TabIndex = 4;
            this.AnswerSave.Text = "Відповісти";
            this.AnswerSave.UseVisualStyleBackColor = true;
            this.AnswerSave.Click += new System.EventHandler(this.AnswerSave_Click);
            // 
            // EndTest
            // 
            this.EndTest.Location = new System.Drawing.Point(587, 363);
            this.EndTest.Name = "EndTest";
            this.EndTest.Size = new System.Drawing.Size(178, 68);
            this.EndTest.TabIndex = 4;
            this.EndTest.Text = "Завершити";
            this.EndTest.UseVisualStyleBackColor = true;
            this.EndTest.Click += new System.EventHandler(this.EndTest_Click);
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(86, 363);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(94, 68);
            this.Last.TabIndex = 2;
            this.Last.Text = "<";
            this.Last.UseVisualStyleBackColor = true;
            this.Last.Click += new System.EventHandler(this.Last_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndTest);
            this.Controls.Add(this.AnswerSave);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.groupBox2);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Last;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button AnswerSave;
        private System.Windows.Forms.Button EndTest;
    }
}