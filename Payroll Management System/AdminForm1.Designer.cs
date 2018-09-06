namespace Payroll_Management_System
{
    partial class AdminForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm1));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn1up = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECT DESIRED SECTION";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Image = global::Payroll_Management_System.Properties.Resources.users_icon;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(24, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 59);
            this.label5.TabIndex = 7;
            this.label5.Text = "STAFFS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Image = global::Payroll_Management_System.Properties.Resources.Teachers_icon;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(421, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "CHAIRMAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Image = global::Payroll_Management_System.Properties.Resources.Teachers_icon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(203, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 59);
            this.label2.TabIndex = 5;
            this.label2.Text = "ASSISTANT PROF.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Image = global::Payroll_Management_System.Properties.Resources.Teachers_icon;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(24, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 59);
            this.label4.TabIndex = 4;
            this.label4.Text = "LECTURER";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Payroll_Management_System.Properties.Resources.BUBT_logo;
            this.pictureBox1.Location = new System.Drawing.Point(207, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 218);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn1up
            // 
            this.btn1up.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1up.Image = global::Payroll_Management_System.Properties.Resources.Actions_system_log_out_icon;
            this.btn1up.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1up.Location = new System.Drawing.Point(438, 437);
            this.btn1up.Name = "btn1up";
            this.btn1up.Size = new System.Drawing.Size(141, 54);
            this.btn1up.TabIndex = 24;
            this.btn1up.Text = "PREVIOUS";
            this.btn1up.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1up.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn1up.UseVisualStyleBackColor = true;
            this.btn1up.Click += new System.EventHandler(this.btn1up_Click);
            // 
            // AdminForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 515);
            this.Controls.Add(this.btn1up);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUBT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn1up;
    }
}