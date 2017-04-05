
using System;
using System.Windows.Forms;
namespace SimpleTaskManager1
{
    partial class Form1
    {
#pragma warning disable CS0414 // The field 'Form1.components' is assigned but its value is never used
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
#pragma warning restore CS0414 // The field 'Form1.components' is assigned but its value is never used

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewKillListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Kill_list_Process = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.AllowColumnReorder = true;
            this.lv.AllowDrop = true;
            this.lv.BackColor = System.Drawing.Color.White;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            resources.ApplyResources(this.lv, "lv");
            this.lv.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lv.Name = "lv";
            this.lv.TileSize = new System.Drawing.Size(600, 450);
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            this.lv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RowSelect);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem7,
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem5});
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            resources.ApplyResources(this.menuItem7, "menuItem7");
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            resources.ApplyResources(this.menuItem1, "menuItem1");
            this.menuItem1.Click += new System.EventHandler(this.OpenContainingFolder);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            resources.ApplyResources(this.menuItem2, "menuItem2");
            this.menuItem2.Click += new System.EventHandler(this.Kill_Selected_Process);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            resources.ApplyResources(this.menuItem3, "menuItem3");
            this.menuItem3.Click += new System.EventHandler(this.Ml_Kill_List_Clicked);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 5;
            resources.ApplyResources(this.menuItem5, "menuItem5");
            this.menuItem5.Click += new System.EventHandler(this.Add_Kill_List_Clicked);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewTaskToolStripMenuItem,
            this.viewKillListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // startNewTaskToolStripMenuItem
            // 
            this.startNewTaskToolStripMenuItem.Name = "startNewTaskToolStripMenuItem";
            resources.ApplyResources(this.startNewTaskToolStripMenuItem, "startNewTaskToolStripMenuItem");
            this.startNewTaskToolStripMenuItem.Click += new System.EventHandler(this.startNewTaskToolStripMenuItem_Click);
            // 
            // viewKillListToolStripMenuItem
            // 
            this.viewKillListToolStripMenuItem.Name = "viewKillListToolStripMenuItem";
            resources.ApplyResources(this.viewKillListToolStripMenuItem, "viewKillListToolStripMenuItem");
            this.viewKillListToolStripMenuItem.Click += new System.EventHandler(this.viewKillListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Kill_list_Process
            // 
            this.Kill_list_Process.BackColor = System.Drawing.SystemColors.Window;
            this.Kill_list_Process.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Kill_list_Process, "Kill_list_Process");
            this.Kill_list_Process.Name = "Kill_list_Process";
            this.Kill_list_Process.UseVisualStyleBackColor = false;
            this.Kill_list_Process.Click += new System.EventHandler(this.Kill_list_Process_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ContextMenu = this.contextMenu1;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Kill_list_Process);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        

        private void MyInitializetion()
        {

            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = " Process";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 220;

            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Memory (MB)";
            columnHeader2.TextAlign = HorizontalAlignment.Left;
            columnHeader2.Width = 186;

            /*ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader2.Text = "CPU";
            columnHeader2.TextAlign = HorizontalAlignment.Left;
            columnHeader2.Width = 146;*/

            this.lv.Columns.Add(columnHeader1);
            this.lv.Columns.Add(columnHeader2);
            //this.lv.Columns.Add(columnHeader3);


        }


        #endregion

        public System.Windows.Forms.ListView lv;
        public System.Timers.Timer timer = new System.Timers.Timer(4000);
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuItem menuItem3;
        private Button button4;
        private Button Kill_list_Process;
        private MenuItem menuItem5;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuItem menuItem7;
        private ToolStripMenuItem startNewTaskToolStripMenuItem;
        private Button button1;
        private MenuItem menuItem4;
        private Button button2;
        private Button button3;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem viewKillListToolStripMenuItem;
    }
}

