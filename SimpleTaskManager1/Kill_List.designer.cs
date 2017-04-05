namespace SimpleTaskManager1
{
    partial class Kill_List
    {
#pragma warning disable CS0414 // The field 'Kill_List.components' is assigned but its value is never used
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
#pragma warning restore CS0414 // The field 'Kill_List.components' is assigned but its value is never used

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kill_List));
            this.savebtn = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.White;
            this.savebtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.Black;
            this.savebtn.Location = new System.Drawing.Point(190, 29);
            this.savebtn.Margin = new System.Windows.Forms.Padding(4);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(100, 28);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "Save List";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(13, 29);
            this.txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(147, 266);
            this.txtbox.TabIndex = 2;
            // 
            // Kill_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 314);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.savebtn);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Kill_List";
            this.ShowIcon = false;
            this.Text = "Kill List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kill_List_is_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.TextBox txtbox;
    }
}