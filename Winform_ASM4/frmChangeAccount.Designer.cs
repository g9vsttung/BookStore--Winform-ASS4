
namespace Winform_ASM4
{
    partial class frmChangeAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbRs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role : Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmpName : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(225, 112);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(187, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(225, 189);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(187, 22);
            this.txtPass.TabIndex = 4;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(225, 270);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(166, 46);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change Password";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbRs
            // 
            this.lbRs.AutoSize = true;
            this.lbRs.ForeColor = System.Drawing.Color.Red;
            this.lbRs.Location = new System.Drawing.Point(169, 232);
            this.lbRs.Name = "lbRs";
            this.lbRs.Size = new System.Drawing.Size(0, 21);
            this.lbRs.TabIndex = 6;
            // 
            // frmChangeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.lbRs);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChangeAccount";
            this.Text = "frmChangeAccount";
            this.Load += new System.EventHandler(this.frmChangeAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lbRs;
    }
}