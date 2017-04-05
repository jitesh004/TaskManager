using System;

using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleTaskManager1
{
    public partial class SingleProcessTree : Form
    {
        
        public SingleProcessTree()
        {
            InitializeComponent();
            GetTree();
        }

        private delegate void AddListViewItemsTolvDel(ListViewItem list);
        private void AddListViewItemsTolv(ListViewItem listVI)
        {

            if (listView1.InvokeRequired)
            {
                Invoke(new AddListViewItemsTolvDel(AddListViewItemsTolv), new object[] { listVI });
            }
            else
                this.listView1.Items.AddRange(new ListViewItem[] { listVI });
        }




        public void GetTree()
        {
            try
            {
                string[] parentname = new string[100];
                string[] parentid = new string[100];
                string[] pid = new string[100];
                int i = 0;


                ListViewItem lv1 = new ListViewItem();
                Form1 obj = new Form1();
                var performanceCounter = new PerformanceCounter("Process", "Creating Process ID", Form1.SelectedProcess);
                var parent = GetProcessIdIfStillRunning((int)performanceCounter.RawValue);


                parentname[i] = parent.ProcessName;
                parentid[i] = parent.ProcessId.ToString();
                lv1 = new ListViewItem(Form1.SelectedProcess);
                Process[] pro = Process.GetProcessesByName(Form1.SelectedProcess);
                foreach (var proc in pro)
                {
                    pid[i] = proc.Id.ToString();
                }
                lv1.SubItems.Add(pid[i]);
                lv1.SubItems.Add(parentname[i]);
                lv1.SubItems.Add(parentid[i]);

                AddListViewItemsTolv(lv1);

                i++;
               
            }
            catch (Exception)
            { }
        }
        
        
        struct MyProcInfo
        {
            public int ProcessId;
            public string ProcessName;
        }

        static MyProcInfo GetProcessIdIfStillRunning(int pid)
        {
            try
            {
                var p = Process.GetProcessById(pid);
                return new MyProcInfo() { ProcessId = p.Id, ProcessName = p.ProcessName };
            }
            catch (ArgumentException)
            {
                return new MyProcInfo() { ProcessId = -1, ProcessName = "No-longer existant process" };
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessTree pt = new ProcessTree();
            pt.Show();
        }
    }
}
