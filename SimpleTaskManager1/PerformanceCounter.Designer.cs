namespace SimpleTaskManager1
{
    partial class Performance_Counter
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.os_label = new System.Windows.Forms.Label();
            this.cpu_progress = new System.Windows.Forms.ProgressBar();
            this.memory_progress = new System.Windows.Forms.ProgressBar();
            this.harddrive_progress = new System.Windows.Forms.ProgressBar();
            this.cpu_text = new System.Windows.Forms.Label();
            this.memory_text = new System.Windows.Forms.Label();
            this.harddrive_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "OS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU Utilization(%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 514);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 80);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hard Drive\r\n(GB)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 90);
            this.label3.TabIndex = 11;
            this.label3.Text = "System RAM \r\n(MB)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // os_label
            // 
            this.os_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.os_label.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.os_label.Location = new System.Drawing.Point(221, 24);
            this.os_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.os_label.Name = "os_label";
            this.os_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.os_label.Size = new System.Drawing.Size(729, 75);
            this.os_label.TabIndex = 12;
            this.os_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpu_progress
            // 
            this.cpu_progress.Location = new System.Drawing.Point(352, 211);
            this.cpu_progress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpu_progress.Name = "cpu_progress";
            this.cpu_progress.Size = new System.Drawing.Size(631, 35);
            this.cpu_progress.TabIndex = 13;
            // 
            // memory_progress
            // 
            this.memory_progress.Location = new System.Drawing.Point(352, 351);
            this.memory_progress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memory_progress.Name = "memory_progress";
            this.memory_progress.Size = new System.Drawing.Size(631, 35);
            this.memory_progress.TabIndex = 14;
            // 
            // harddrive_progress
            // 
            this.harddrive_progress.Location = new System.Drawing.Point(352, 519);
            this.harddrive_progress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.harddrive_progress.Name = "harddrive_progress";
            this.harddrive_progress.Size = new System.Drawing.Size(631, 35);
            this.harddrive_progress.TabIndex = 15;
            // 
            // cpu_text
            // 
            this.cpu_text.AutoSize = true;
            this.cpu_text.Location = new System.Drawing.Point(625, 189);
            this.cpu_text.Name = "cpu_text";
            this.cpu_text.Size = new System.Drawing.Size(49, 20);
            this.cpu_text.TabIndex = 16;
            this.cpu_text.Text = "0/100";
            // 
            // memory_text
            // 
            this.memory_text.AutoSize = true;
            this.memory_text.Location = new System.Drawing.Point(613, 328);
            this.memory_text.Name = "memory_text";
            this.memory_text.Size = new System.Drawing.Size(99, 20);
            this.memory_text.TabIndex = 17;
            this.memory_text.Text = "0(MB)/0(MB)";
            // 
            // harddrive_text
            // 
            this.harddrive_text.AutoSize = true;
            this.harddrive_text.Location = new System.Drawing.Point(618, 491);
            this.harddrive_text.Name = "harddrive_text";
            this.harddrive_text.Size = new System.Drawing.Size(99, 20);
            this.harddrive_text.TabIndex = 18;
            this.harddrive_text.Text = "0(GB)/0(GB)";
            // 
            // Performance_Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 692);
            this.Controls.Add(this.harddrive_text);
            this.Controls.Add(this.memory_text);
            this.Controls.Add(this.cpu_text);
            this.Controls.Add(this.harddrive_progress);
            this.Controls.Add(this.memory_progress);
            this.Controls.Add(this.cpu_progress);
            this.Controls.Add(this.os_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Performance_Counter";
            this.Text = "Performance Counter";
            this.Load += new System.EventHandler(this.Performance_Counter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label os_label;
        private System.Windows.Forms.ProgressBar cpu_progress;
        private System.Windows.Forms.ProgressBar memory_progress;
        private System.Windows.Forms.ProgressBar harddrive_progress;
        private System.Windows.Forms.Label cpu_text;
        private System.Windows.Forms.Label memory_text;
        private System.Windows.Forms.Label harddrive_text;
    }
}