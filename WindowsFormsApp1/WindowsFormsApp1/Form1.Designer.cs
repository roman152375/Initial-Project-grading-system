namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.lblFinalMark = new System.Windows.Forms.Label();
            this.txtFinalMark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuiz1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuiz2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQuiz3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnCaculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(118, 7);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(335, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "IT895\r\n";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(335, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Roman Islam Ratul";
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Program Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(118, 72);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(335, 20);
            this.txtProgram.TabIndex = 3;
            this.txtProgram.Text = "Microsoft .net Specialist Diploma";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Module:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(118, 104);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(335, 20);
            this.txtModule.TabIndex = 4;
            this.txtModule.Text = "Developing and Implementing Windows Based Applications";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Start Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtstDate
            // 
            this.txtstDate.Location = new System.Drawing.Point(119, 132);
            this.txtstDate.Name = "txtstDate";
            this.txtstDate.Size = new System.Drawing.Size(334, 20);
            this.txtstDate.TabIndex = 5;
            this.txtstDate.Text = "18 Feb 2020";
            this.txtstDate.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "End Date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(118, 164);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(335, 20);
            this.txtEndDate.TabIndex = 6;
            this.txtEndDate.Text = "13 Mar 2020";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(12, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Instructor:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtInstructor
            // 
            this.txtInstructor.Location = new System.Drawing.Point(118, 196);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(335, 20);
            this.txtInstructor.TabIndex = 7;
            this.txtInstructor.Text = "Eduardo Jaime";
            // 
            // lblFinalMark
            // 
            this.lblFinalMark.BackColor = System.Drawing.SystemColors.Info;
            this.lblFinalMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFinalMark.Location = new System.Drawing.Point(12, 232);
            this.lblFinalMark.Name = "lblFinalMark";
            this.lblFinalMark.Size = new System.Drawing.Size(100, 20);
            this.lblFinalMark.TabIndex = 15;
            this.lblFinalMark.Text = "Final Mark:";
            this.lblFinalMark.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFinalMark.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtFinalMark
            // 
            this.txtFinalMark.Location = new System.Drawing.Point(118, 230);
            this.txtFinalMark.Name = "txtFinalMark";
            this.txtFinalMark.Size = new System.Drawing.Size(335, 20);
            this.txtFinalMark.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grading Calculator";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Attendance(5%) :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(119, 369);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(138, 20);
            this.txtAttendance.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label11.Location = new System.Drawing.Point(12, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quiz 1(5%):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQuiz1
            // 
            this.txtQuiz1.Location = new System.Drawing.Point(119, 402);
            this.txtQuiz1.Name = "txtQuiz1";
            this.txtQuiz1.Size = new System.Drawing.Size(138, 20);
            this.txtQuiz1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(12, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Quiz 2(5%):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQuiz2
            // 
            this.txtQuiz2.Location = new System.Drawing.Point(119, 432);
            this.txtQuiz2.Name = "txtQuiz2";
            this.txtQuiz2.Size = new System.Drawing.Size(138, 20);
            this.txtQuiz2.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(12, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Quiz 3(5%):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQuiz3
            // 
            this.txtQuiz3.Location = new System.Drawing.Point(118, 459);
            this.txtQuiz3.Name = "txtQuiz3";
            this.txtQuiz3.Size = new System.Drawing.Size(139, 20);
            this.txtQuiz3.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(13, 494);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Project(15%) :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(119, 494);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(138, 20);
            this.txtProject.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(12, 526);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Assignment(5%) :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAssignment
            // 
            this.txtAssignment.Location = new System.Drawing.Point(119, 524);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(138, 20);
            this.txtAssignment.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(12, 556);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Final Exam(60%):";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(119, 556);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(138, 20);
            this.txtFinal.TabIndex = 16;
            // 
            // btnCaculate
            // 
            this.btnCaculate.Location = new System.Drawing.Point(12, 621);
            this.btnCaculate.Name = "btnCaculate";
            this.btnCaculate.Size = new System.Drawing.Size(75, 23);
            this.btnCaculate.TabIndex = 32;
            this.btnCaculate.Text = "&Calculate";
            this.btnCaculate.UseVisualStyleBackColor = true;
            this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(227, 621);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(444, 621);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.BackColor = System.Drawing.SystemColors.Info;
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrade.Location = new System.Drawing.Point(13, 261);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(100, 20);
            this.lblGrade.TabIndex = 35;
            this.lblGrade.Text = "Grade:";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(119, 261);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(334, 20);
            this.txtGrade.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(565, 672);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCaculate);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAssignment);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtQuiz3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtQuiz2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQuiz1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFinalMark);
            this.Controls.Add(this.lblFinalMark);
            this.Controls.Add(this.txtInstructor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtstDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grading System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.Label lblFinalMark;
        private System.Windows.Forms.TextBox txtFinalMark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQuiz1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuiz2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQuiz3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnCaculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
    }
}

