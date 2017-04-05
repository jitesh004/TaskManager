namespace SimpleTaskManager1
{
    partial class RunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunForm));
            this.runtxt = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.Okbtn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runtxt
            // 
            this.runtxt.BackColor = System.Drawing.Color.White;
            this.runtxt.Location = new System.Drawing.Point(16, 44);
            this.runtxt.Margin = new System.Windows.Forms.Padding(4);
            this.runtxt.Name = "runtxt";
            this.runtxt.Size = new System.Drawing.Size(240, 23);
            this.runtxt.TabIndex = 0;
            this.runtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.runtxt_KeyDown);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Window;
            this.btnBrowse.Location = new System.Drawing.Point(284, 41);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(104, 28);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Okbtn
            // 
            this.Okbtn.BackColor = System.Drawing.Color.White;
            this.Okbtn.Location = new System.Drawing.Point(304, 91);
            this.Okbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(84, 28);
            this.Okbtn.TabIndex = 2;
            this.Okbtn.Text = "Ok";
            this.Okbtn.UseVisualStyleBackColor = false;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(196, 91);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // RunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(404, 134);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.runtxt);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RunForm";
            this.Text = "RunForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox runtxt;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.Button btnCancel;
    }
}