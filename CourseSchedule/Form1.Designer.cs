
namespace CourseSchedule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseIn = new System.Windows.Forms.TextBox();
            this.courseInfoBtn = new System.Windows.Forms.Button();
            this.courseLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.instrutorLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.roomLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseIn);
            this.groupBox1.Controls.Add(this.courseInfoBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(241, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Course";
            // 
            // courseIn
            // 
            this.courseIn.Location = new System.Drawing.Point(15, 25);
            this.courseIn.Multiline = true;
            this.courseIn.Name = "courseIn";
            this.courseIn.Size = new System.Drawing.Size(279, 46);
            this.courseIn.TabIndex = 2;
            // 
            // courseInfoBtn
            // 
            this.courseInfoBtn.Location = new System.Drawing.Point(97, 95);
            this.courseInfoBtn.Name = "courseInfoBtn";
            this.courseInfoBtn.Size = new System.Drawing.Size(116, 27);
            this.courseInfoBtn.TabIndex = 1;
            this.courseInfoBtn.Text = "Course Info";
            this.courseInfoBtn.UseVisualStyleBackColor = true;
            this.courseInfoBtn.Click += new System.EventHandler(this.courseInfoBtn_Click);
            // 
            // courseLbl
            // 
            this.courseLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseLbl.Location = new System.Drawing.Point(15, 56);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(125, 25);
            this.courseLbl.TabIndex = 2;
            this.courseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.instrutorLbl);
            this.groupBox2.Controls.Add(this.timeLbl);
            this.groupBox2.Controls.Add(this.roomLbl);
            this.groupBox2.Controls.Add(this.courseLbl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(241, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 198);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Instructor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Room Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Course Number";
            // 
            // instrutorLbl
            // 
            this.instrutorLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instrutorLbl.Location = new System.Drawing.Point(15, 127);
            this.instrutorLbl.Name = "instrutorLbl";
            this.instrutorLbl.Size = new System.Drawing.Size(125, 25);
            this.instrutorLbl.TabIndex = 5;
            this.instrutorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLbl
            // 
            this.timeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLbl.Location = new System.Drawing.Point(169, 127);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(125, 25);
            this.timeLbl.TabIndex = 4;
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomLbl
            // 
            this.roomLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomLbl.Location = new System.Drawing.Point(169, 56);
            this.roomLbl.Name = "roomLbl";
            this.roomLbl.Size = new System.Drawing.Size(125, 25);
            this.roomLbl.TabIndex = 3;
            this.roomLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(410, 400);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(140, 34);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(241, 400);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(140, 34);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button courseInfoBtn;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label instrutorLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label roomLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox courseIn;
    }
}

