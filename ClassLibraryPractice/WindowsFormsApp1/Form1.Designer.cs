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
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Resault = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(246, 58);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(100, 26);
            this.tbFirst.TabIndex = 0;
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(470, 58);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(100, 26);
            this.tbSecond.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(256, 182);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(90, 34);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Multi
            // 
            this.Multi.Location = new System.Drawing.Point(470, 182);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(100, 34);
            this.Multi.TabIndex = 3;
            this.Multi.Text = "Multi";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Resault
            // 
            this.Resault.AutoSize = true;
            this.Resault.Location = new System.Drawing.Point(656, 116);
            this.Resault.Name = "Resault";
            this.Resault.Size = new System.Drawing.Size(64, 20);
            this.Resault.TabIndex = 4;
            this.Resault.Text = "Resault";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resault);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.tbFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Label Resault;
    }
}

