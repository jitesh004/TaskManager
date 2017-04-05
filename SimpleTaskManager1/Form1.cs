using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using TaskManager;

namespace SimpleTaskManager1
{
    public partial class Form1 : Form
    {
        private int noOfProcess;
        public static string SelectedProcess;
        private string[] path;
        private int index;
        Process[] process;
        Kill_List Window_kill_list;
        
        public Form1()
        {
            InitializeComponent();
            path = new string[100];
            GetProcesses();
            ConformXmlFile();
            Window_kill_list = new Kill_List("Kill List");
        }

        public Form1(object j )
        {
            Kill_List kl = new Kill_List();
            kl.ReadXmlFile("Kill List.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           AddtoControl();
        }



        private void AgainInitilizeLV()
        {
            this.lv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lv.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(24, 67);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(331, 394);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
        }


        private delegate void AddtoControlDel();

        private void AddtoControl()
        {
            try
            {
                if (lv.InvokeRequired)
                {
                    Invoke(new AddtoControlDel(AddtoControl), new object[] { });
                }
                else
                    this.Controls.Add(lv);
            }catch(Exception)
            {

            }
        }
        
        private delegate void AddListViewItemsTolvDel(ListViewItem list);

        private void AddListViewItemsTolv(ListViewItem listVI)
        {

            if (lv.InvokeRequired)
            {
                Invoke(new AddListViewItemsTolvDel(AddListViewItemsTolv), new object[] { listVI });
            }
            else
                this.lv.Items.AddRange(new ListViewItem[] { listVI });
        }
        
        private void AddTimer()
        {
            timer.Interval = 6000;
            this.timer.Enabled = true;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(TimerElapsed);
        }


        private void GetProcesses()
        {
            
            try
            {
                this.lv.Clear();
                AddTimer();
                MyInitializetion();
                string[] mainwindowtitle = new string[100];
                string[] Mem_Usage = new string[500];
                string[] ProcessNames = new string[500];
                double[] converter1 = new double[500];
                string mb = " MB";
                process = Process.GetProcesses();
                noOfProcess = 0;
                int i = 0;
                
                ListViewItem lvi = new ListViewItem();

                foreach (Process pro in process)
                {
                   
                    ProcessNames[i] = pro.ProcessName;
                   
                    Mem_Usage[i] = Convert.ToString(Math.Round((converter1[i] = pro.PeakWorkingSet64) / 1024 / 1024, 2));
                    
                 
                    lvi = new ListViewItem(ProcessNames[i]);
                    lvi.SubItems.Add(Mem_Usage[i]+mb);
                    
                    AddListViewItemsTolv(lvi);
                    i++;
                    noOfProcess++;
                    
                }
                
            }
            catch(Exception)
            {
            }
            
        }


        private void RowSelect(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lv.HitTest(e.X, e.Y);

            ListViewItem.ListViewSubItem subitem = null;
            if (info != null)
            {
                try
                {
                    subitem = info.Item.GetSubItemAt(e.X, e.Y);
                    index = info.Item.Index;
                }
                catch
                {

                }
            }
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                SelectedProcess = subitem.Text;
            }
         
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
           Check4Processes();
        }


        private void Check4Processes()
        {
            double[] converter1 = new double[500];
            Process[] gPro = Process.GetProcesses();
            int Numpro = 0;
            string[] names = new string[500];
            string[] mem = new string[500];
            foreach (Process pro in gPro)
            {
                names[Numpro] = pro.ProcessName;
                mem[Numpro] = Convert.ToString(Math.Round((converter1[Numpro] = pro.PagedMemorySize64) / 1024 / 1024, 2));
                Numpro++;
           
            }
           if (Numpro < noOfProcess)
            {
                GetProcesses();
               
                AddtoControl();
            }
            if (Numpro > noOfProcess)
            {
                GetProcesses();
              
                AddtoControl();
            }
        }
        
        private void KillListButton_Clicked(object sender, EventArgs e)
        {
           
        }
        
        private void Add_Kill_List_Clicked(object sender, EventArgs e)
        {
            if (Window_kill_list.IsDisposed)
            {
                Window_kill_list = new Kill_List("Kill List");
            }
            Window_kill_list.txtbox.Text += SelectedProcess + "\r\n";
            Window_kill_list.AddOneToList("Kill List.xml");
            Window_kill_list.Show();
         }

   
        private void OpenContainingFolder(object sender, EventArgs e)
        {
            if (!File.Exists(SelectedProcess))
            {
                Process p = new Process();
                p.StartInfo.FileName = "explorer.exe";
                p.StartInfo.Arguments = "/Select," + path[index];
                p.Start();
            }
            else
                System.Windows.Forms.MessageBox.Show("The process does not exist");
        }

        private void Kill_Selected_Process(object sender, EventArgs e)
        {
            foreach (var process1 in Process.GetProcessesByName(SelectedProcess))
            {
                try
                {
                    while (!process1.HasExited)
                    {
                        process1.Kill();
                    }
                    Check4Processes();
                }
                catch(Win32Exception)
                {

                }
            }

         }
        
        private void Kill_list_Process_Click(object sender, EventArgs e)
        {
            int killed = 0;
            int length = Window_kill_list.TotalTages();
            if (length == 0)
            {
                MessageBox.Show("List is Empty.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {


                    foreach (Process kill in process)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            if ((kill.ProcessName == Window_kill_list.PInKill_List[i]) && !kill.HasExited)
                            {
                                while (!kill.HasExited)
                                {
                                    kill.Kill();
                                }
                                killed++;

                                if (i == length)
                                    length--;
                                break;
                            }

                        }
                        if (killed == length)
                            //Check4Processes();
                            break;
                    }
                    Check4Processes();
                }
                catch(Exception )
                {
                   
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectedProcess == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select The Process!!!");
            }
            else
            {
                foreach (var process1 in Process.GetProcessesByName(SelectedProcess))
                {
                    try
                    {
                        while (!process1.HasExited)
                        {
                            process1.Kill();
                        }
                        Check4Processes();
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);

                    }
                }
            }
            
        }

        private void Ml_Kill_List_Clicked(object sender, EventArgs e)
        {
            KillListButton_Clicked(sender, e);
        }

        private void MS_Kill_List_Clicked(object sender, EventArgs e)
        {
            KillListButton_Clicked(sender, e);
        }
        
        private void killListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KillListButton_Clicked(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            ShowTree st = new ShowTree();
            st.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SelectedProcess == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select The Process!!!");
            }
            else
            {
                SingleProcessTree spt = new SingleProcessTree();
                spt.Show();
            }
            
        }

        public void menuItem7_Click(object sender, EventArgs e)
        {

            SingleProcessTree spt = new SingleProcessTree();
            spt.Show();
        }

        private void startNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunForm frm = new RunForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowTree st = new ShowTree();
            st.Show();
        }
        private void refreshRateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            SystemMonitor sm = new SystemMonitor();
            sm.Show();
        }
        private void btnNewTask_Click(object sender, EventArgs e)
        {

        }
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (SelectedProcess == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select The Process!!!");
            }
            else
            {
                WebForm wf = new WebForm();
                wf.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void viewKillListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Window_kill_list.IsDisposed)
                Window_kill_list = new Kill_List("Kill List");
            Window_kill_list.Show();
        }

       
    }
}
