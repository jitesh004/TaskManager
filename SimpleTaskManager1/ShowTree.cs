using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Windows.Forms;
using System.Linq;

namespace SimpleTaskManager1
{
    public partial class ShowTree : Form
    {
        string[] pname = new string[100];
        string[] parentname = new string[100];
        int[] parentid = new int[100];
        int[] pid = new int[100];
        int i = 0;

        public ShowTree()
        {
            InitializeComponent();
            
        }

        public IEnumerable<Process> GetChildProcesses(Process process)
        {
            List<Process> children = new List<Process>();

            ManagementObjectSearcher mos = new ManagementObjectSearcher(String.Format("Select * From Win32_Process Where ParentProcessID={0}", process.Id));

            foreach (ManagementObject mo in mos.Get())
            {

                Process p1 = Process.GetProcessById(Convert.ToInt32(mo["ProcessID"]));

                children.Add(p1);
            }

            return children;
        }

        public Process GetChildProcesses1(Process process)
        {

            Process p1 = process;

            ManagementObjectSearcher mos = new ManagementObjectSearcher(String.Format("Select * From Win32_Process Where ParentProcessID={0}", process.Id));
            if (mos != null)
            {
                foreach (ManagementObject mo in mos.Get())
                {
                    p1 = Process.GetProcessById(Convert.ToInt32(mo["ProcessID"]));


                }
            }
            return p1;


        }
        


        public void ProcessTree()
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            treeView2.Nodes.Clear();
            
            TreeNode node = new TreeNode();
            TreeNode node1 = new TreeNode();
            TreeNode node2 = new TreeNode();
            TreeNode node3 = new TreeNode();
            int count = 0;
            Font f = new Font("Verdana", 10, FontStyle.Bold);
            progressBar1.Minimum = 1;
            
            progressBar1.Value = 1;
            progressBar1.Step = 1;
            try
            {
               
                Process[] process = new Process[200];

                process = Process.GetProcesses();
                foreach (Process pro in process.AsParallel())
                {
                    count++;
                }
                progressBar1.Maximum = count;
                foreach (Process pro in process.AsParallel())
                {
                    progressBar1.PerformStep();
                    IEnumerable<Process> children = null;
                    for (int j = 0; j <= i; j++)
                    {

                        if (pid[j] == pro.Id)
                        {

                            node = treeView2.Nodes.Add(parentid[j] + " " + " (" + parentname[j] + ")");
                            node.ForeColor = Color.DarkSlateBlue;
                        }
                    }
                    node1 = node.Nodes.Add(pro.Id + " (" + pro.ProcessName + ")");
                    node1.NodeFont = f;

                    children = GetChildProcesses(pro).AsParallel();

                    foreach (var childs in children.AsParallel())
                    {
                        if (childs != null)
                        {
                            
                            string s1 = childs.ToString().Remove(0, 28);
                            char[] MyChar = { ')' };
                            string s2 = s1.Trim(MyChar);

                            Process[] p1 = Process.GetProcessesByName(s2);
                            node2 = node1.Nodes.Add(p1[0].Id + " (" + s2 + ")");
                            Process children2 = GetChildProcesses1(p1[0]);

                            if (children2 != null)
                            {

                                if (children2.ProcessName != s2)
                                {
                                    node3 = node2.Nodes.Add(children2.Id + " (" + children2.ProcessName + ")");


                                }

                            }

                        }
                    }


                }

            
            }
            catch (Exception)
            {

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void ExecuteTree()
        {
            GetTree();
            label1.Visible = true;
            label1.Refresh();
            ProcessTree();
            label1.Visible = false;
            label1.Refresh();
            progressBar1.Value = 1;
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteTree();
            

        }

        public void GetTree()
        {
            i = 0;
            try
            {

                foreach (var p in Process.GetProcesses().AsParallel())
                {
                    var performanceCounter = new PerformanceCounter("Process", "Creating Process ID", p.ProcessName);
                    var parent = GetProcessIdIfStillRunning((int)performanceCounter.RawValue);
                    
                    pid[i] = p.Id;
                    parentname[i] = parent.ProcessName;
                    parentid[i] = parent.ProcessId;

                    i++;


                }
            }
            catch (Exception)
            {

            }
        }

        struct MyProcInfo
        {
            public int ProcessId;
            public string ProcessName;
        }

        static MyProcInfo GetProcessIdIfStillRunning(int pid1)
        {
            try
            {
                var p1 = Process.GetProcessById(pid1);
                return new MyProcInfo() { ProcessId = p1.Id, ProcessName = p1.ProcessName };
            }
            catch (ArgumentException)
            {
                return new MyProcInfo() { ProcessId = -1, ProcessName = "No-longer existant process" };
            }
        }

        int x=0;
        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeText = e.Node.Text;
            string output = selectedNodeText.Substring(0, selectedNodeText.IndexOf("(")).Replace(" ", "");
            x = Convert.ToInt32(output);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                System.Windows.Forms.MessageBox.Show("Please Select The Process!!!");
            }
            else
            {
                Process pro = Process.GetProcessById(x);
                pro.Kill();
                ExecuteTree();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.treeView2.ExpandAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.treeView2.CollapseAll();
        }
    }

}


