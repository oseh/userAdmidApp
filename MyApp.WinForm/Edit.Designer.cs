using System;

namespace MyApp.WinForm
{
    partial class Edit
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
            this.Backbutton1 = new System.Windows.Forms.Button();
            this.Editbutton2 = new System.Windows.Forms.Button();
            this.ForenametextBox1 = new System.Windows.Forms.TextBox();
            this.SurnametextBox2 = new System.Windows.Forms.TextBox();
            this.Forenamelabel1 = new System.Windows.Forms.Label();
            this.Surnamelabel2 = new System.Windows.Forms.Label();
            this.DateOfBirthlabel3 = new System.Windows.Forms.Label();
            this.IsAtiveCheckBox1 = new System.Windows.Forms.CheckBox();
            this.DateOfBirthtextBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Backbutton1
            // 
            this.Backbutton1.Location = new System.Drawing.Point(449, 325);
            this.Backbutton1.Name = "Backbutton1";
            this.Backbutton1.Size = new System.Drawing.Size(120, 46);
            this.Backbutton1.TabIndex = 0;
            this.Backbutton1.Text = "Back";
            this.Backbutton1.UseVisualStyleBackColor = true;
            this.Backbutton1.Click += new System.EventHandler(this.Backbutton1_Click);
            // 
            // Editbutton2
            // 
            this.Editbutton2.Location = new System.Drawing.Point(631, 325);
            this.Editbutton2.Name = "Editbutton2";
            this.Editbutton2.Size = new System.Drawing.Size(120, 46);
            this.Editbutton2.TabIndex = 1;
            this.Editbutton2.Text = "Edit";
            this.Editbutton2.UseVisualStyleBackColor = true;
            this.Editbutton2.Click += new System.EventHandler(this.Editbutton2_Click);
            // 
            // ForenametextBox1
            // 
            this.ForenametextBox1.Location = new System.Drawing.Point(44, 64);
            this.ForenametextBox1.Name = "ForenametextBox1";
            this.ForenametextBox1.Size = new System.Drawing.Size(373, 26);
            this.ForenametextBox1.TabIndex = 2;
            // 
            // SurnametextBox2
            // 
            this.SurnametextBox2.Location = new System.Drawing.Point(44, 111);
            this.SurnametextBox2.Name = "SurnametextBox2";
            this.SurnametextBox2.Size = new System.Drawing.Size(373, 26);
            this.SurnametextBox2.TabIndex = 3;
            // 
            // Forenamelabel1
            // 
            this.Forenamelabel1.AutoSize = true;
            this.Forenamelabel1.Location = new System.Drawing.Point(445, 69);
            this.Forenamelabel1.Name = "Forenamelabel1";
            this.Forenamelabel1.Size = new System.Drawing.Size(82, 20);
            this.Forenamelabel1.TabIndex = 9;
            this.Forenamelabel1.Text = "Forename";
            // 
            // Surnamelabel2
            // 
            this.Surnamelabel2.AutoSize = true;
            this.Surnamelabel2.Location = new System.Drawing.Point(445, 114);
            this.Surnamelabel2.Name = "Surnamelabel2";
            this.Surnamelabel2.Size = new System.Drawing.Size(74, 20);
            this.Surnamelabel2.TabIndex = 10;
            this.Surnamelabel2.Text = "Surname";
            // 
            // DateOfBirthlabel3
            // 
            this.DateOfBirthlabel3.AutoSize = true;
            this.DateOfBirthlabel3.Location = new System.Drawing.Point(445, 212);
            this.DateOfBirthlabel3.Name = "DateOfBirthlabel3";
            this.DateOfBirthlabel3.Size = new System.Drawing.Size(182, 20);
            this.DateOfBirthlabel3.TabIndex = 11;
            this.DateOfBirthlabel3.Text = "Date Of Birth (dd/mm/yy)";
            // 
            // IsAtiveCheckBox1
            // 
            this.IsAtiveCheckBox1.AutoSize = true;
            this.IsAtiveCheckBox1.Location = new System.Drawing.Point(44, 160);
            this.IsAtiveCheckBox1.Name = "IsAtiveCheckBox1";
            this.IsAtiveCheckBox1.Size = new System.Drawing.Size(91, 24);
            this.IsAtiveCheckBox1.TabIndex = 12;
            this.IsAtiveCheckBox1.Text = "Is Ative ";
            this.IsAtiveCheckBox1.UseVisualStyleBackColor = true;
            // 
            // DateOfBirthtextBox4
            // 
            this.DateOfBirthtextBox4.Location = new System.Drawing.Point(44, 209);
            this.DateOfBirthtextBox4.Name = "DateOfBirthtextBox4";
            this.DateOfBirthtextBox4.Size = new System.Drawing.Size(373, 26);
            this.DateOfBirthtextBox4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add a new user below.";


            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsAtiveCheckBox1);
            this.Controls.Add(this.DateOfBirthlabel3);
            this.Controls.Add(this.Surnamelabel2);
            this.Controls.Add(this.Forenamelabel1);
            this.Controls.Add(this.DateOfBirthtextBox4);
            this.Controls.Add(this.SurnametextBox2);
            this.Controls.Add(this.ForenametextBox1);
            this.Controls.Add(this.Editbutton2);
            this.Controls.Add(this.Backbutton1);
            this.Name = "Edit";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button Backbutton1;
        private System.Windows.Forms.Button Editbutton2;
        private System.Windows.Forms.TextBox ForenametextBox1;
        private System.Windows.Forms.TextBox SurnametextBox2;
        private System.Windows.Forms.Label Forenamelabel1;
        private System.Windows.Forms.Label Surnamelabel2;
        private System.Windows.Forms.Label DateOfBirthlabel3;
        private System.Windows.Forms.CheckBox IsAtiveCheckBox1;
        public System.Windows.Forms.TextBox DateOfBirthtextBox4;

        #endregion

        private System.Windows.Forms.Label label1;
    }
}