﻿namespace ManyToManyRelationship
{
    partial class MainUI
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
            this.studentEntryButton = new System.Windows.Forms.Button();
            this.courseEntryButton = new System.Windows.Forms.Button();
            this.enrollmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentEntryButton
            // 
            this.studentEntryButton.Location = new System.Drawing.Point(89, 43);
            this.studentEntryButton.Name = "studentEntryButton";
            this.studentEntryButton.Size = new System.Drawing.Size(127, 23);
            this.studentEntryButton.TabIndex = 0;
            this.studentEntryButton.Text = "Student Entry";
            this.studentEntryButton.UseVisualStyleBackColor = true;
            this.studentEntryButton.Click += new System.EventHandler(this.studentEntryButton_Click);
            // 
            // courseEntryButton
            // 
            this.courseEntryButton.Location = new System.Drawing.Point(101, 92);
            this.courseEntryButton.Name = "courseEntryButton";
            this.courseEntryButton.Size = new System.Drawing.Size(75, 23);
            this.courseEntryButton.TabIndex = 1;
            this.courseEntryButton.Text = "Course Entry";
            this.courseEntryButton.UseVisualStyleBackColor = true;
            this.courseEntryButton.Click += new System.EventHandler(this.courseEntryButton_Click);
            // 
            // enrollmentButton
            // 
            this.enrollmentButton.Location = new System.Drawing.Point(89, 138);
            this.enrollmentButton.Name = "enrollmentButton";
            this.enrollmentButton.Size = new System.Drawing.Size(75, 23);
            this.enrollmentButton.TabIndex = 2;
            this.enrollmentButton.Text = "Enrollment";
            this.enrollmentButton.UseVisualStyleBackColor = true;
            this.enrollmentButton.Click += new System.EventHandler(this.enrollmentButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.enrollmentButton);
            this.Controls.Add(this.courseEntryButton);
            this.Controls.Add(this.studentEntryButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentEntryButton;
        private System.Windows.Forms.Button courseEntryButton;
        private System.Windows.Forms.Button enrollmentButton;
    }
}