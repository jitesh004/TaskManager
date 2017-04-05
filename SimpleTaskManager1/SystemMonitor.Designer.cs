namespace SimpleTaskManager1
{
    partial class SystemMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemMonitor));
            this.perfCPU = new System.Diagnostics.PerformanceCounter();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.perfRAM = new System.Diagnostics.PerformanceCounter();
            this.perfSystem = new System.Diagnostics.PerformanceCounter();
            this.proCPU = new System.Windows.Forms.ProgressBar();
            this.proRAM = new System.Windows.Forms.ProgressBar();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.perfDisk = new System.Diagnostics.PerformanceCounter();
            this.lblDisk = new System.Windows.Forms.Label();
            this.proDisk = new System.Windows.Forms.ProgressBar();
            this.labelDisk = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfDisk)).BeginInit();
            this.SuspendLayout();
            // 
            // perfCPU
            // 
            this.perfCPU.CategoryName = "Processor";
            this.perfCPU.CounterName = "% Processor Time";
            this.perfCPU.InstanceName = "_Total";
            // 
            // lblCPU
            // 
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.Black;
            this.lblCPU.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblCPU.Location = new System.Drawing.Point(92, 123);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(97, 25);
            this.lblCPU.TabIndex = 0;
            this.lblCPU.Text = "CPU";
            // 
            // lblRAM
            // 
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.Color.Black;
            this.lblRAM.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblRAM.Location = new System.Drawing.Point(89, 191);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(97, 25);
            this.lblRAM.TabIndex = 1;
            this.lblRAM.Text = "RAM";
            // 
            // lblSystem
            // 
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.Black;
            this.lblSystem.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblSystem.Location = new System.Drawing.Point(60, 305);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(509, 25);
            this.lblSystem.TabIndex = 2;
            this.lblSystem.Text = "UP TIME";
            // 
            // perfRAM
            // 
            this.perfRAM.CategoryName = "Memory";
            this.perfRAM.CounterName = "% Committed Bytes In Use";
            // 
            // perfSystem
            // 
            this.perfSystem.CategoryName = "System";
            this.perfSystem.CounterName = "System Up Time";
            // 
            // proCPU
            // 
            this.proCPU.Location = new System.Drawing.Point(217, 123);
            this.proCPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proCPU.Name = "proCPU";
            this.proCPU.Size = new System.Drawing.Size(380, 25);
            this.proCPU.TabIndex = 3;
            // 
            // proRAM
            // 
            this.proRAM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.proRAM.Location = new System.Drawing.Point(217, 191);
            this.proRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proRAM.Name = "proRAM";
            this.proRAM.Size = new System.Drawing.Size(380, 25);
            this.proRAM.TabIndex = 4;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.ForeColor = System.Drawing.Color.Black;
            this.labelCPU.Location = new System.Drawing.Point(604, 129);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(32, 14);
            this.labelCPU.TabIndex = 6;
            this.labelCPU.Text = "0 %";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.ForeColor = System.Drawing.Color.Black;
            this.labelRAM.Location = new System.Drawing.Point(604, 197);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(32, 14);
            this.labelRAM.TabIndex = 7;
            this.labelRAM.Text = "0 %";
            // 
            // lblOS
            // 
            this.lblOS.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.ForeColor = System.Drawing.Color.Black;
            this.lblOS.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblOS.Location = new System.Drawing.Point(11, 17);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(680, 57);
            this.lblOS.TabIndex = 8;
            // 
            // perfDisk
            // 
            this.perfDisk.CategoryName = "PhysicalDisk";
            this.perfDisk.CounterName = "% Disk Time";
            this.perfDisk.InstanceName = "0 C: E: D:";
            // 
            // lblDisk
            // 
            this.lblDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisk.ForeColor = System.Drawing.Color.Black;
            this.lblDisk.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDisk.Location = new System.Drawing.Point(40, 251);
            this.lblDisk.Name = "lblDisk";
            this.lblDisk.Size = new System.Drawing.Size(153, 25);
            this.lblDisk.TabIndex = 9;
            this.lblDisk.Text = "Disk Usage";
            // 
            // proDisk
            // 
            this.proDisk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.proDisk.Location = new System.Drawing.Point(217, 251);
            this.proDisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proDisk.Name = "proDisk";
            this.proDisk.Size = new System.Drawing.Size(380, 25);
            this.proDisk.TabIndex = 10;
            // 
            // labelDisk
            // 
            this.labelDisk.AutoSize = true;
            this.labelDisk.ForeColor = System.Drawing.Color.Black;
            this.labelDisk.Location = new System.Drawing.Point(607, 257);
            this.labelDisk.Name = "labelDisk";
            this.labelDisk.Size = new System.Drawing.Size(32, 14);
            this.labelDisk.TabIndex = 11;
            this.labelDisk.Text = "0 %";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(511, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Speak";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SystemMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDisk);
            this.Controls.Add(this.proDisk);
            this.Controls.Add(this.lblDisk);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.proRAM);
            this.Controls.Add(this.proCPU);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SystemMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Monitor ";
            this.Load += new System.EventHandler(this.SystemMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfDisk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter perfCPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblSystem;
        private System.Diagnostics.PerformanceCounter perfSystem;
        private System.Windows.Forms.ProgressBar proCPU;
        private System.Windows.Forms.ProgressBar proRAM;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label lblOS;
        private System.Diagnostics.PerformanceCounter perfRAM;
        private System.Diagnostics.PerformanceCounter perfDisk;
        private System.Windows.Forms.Label lblDisk;
        private System.Windows.Forms.ProgressBar proDisk;
        private System.Windows.Forms.Label labelDisk;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
    }
}