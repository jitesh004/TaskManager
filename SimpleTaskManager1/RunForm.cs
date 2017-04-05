using System;

using System.Windows.Forms;

using System.Diagnostics;

namespace SimpleTaskManager1
{
    public partial class RunForm : Form
    {
        public RunForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select a file to Run";
                dialog.Filter = "Executable files  |*.exe";
                // DialogResult result = dialog.ShowDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    runtxt.Text = dialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Some error occur to start the process");
            }
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                Process.Start(runtxt.Text);
            }
            catch (System.ObjectDisposedException ex)
            {
                MessageBox.Show("Error occur In dispose Exception " + ex.Message);
            }
            catch (System.ComponentModel.Win32Exception ewin32)
            {
                MessageBox.Show("Error occur in Win32 Exception " + ewin32.Message);
            }
            catch (ArgumentException eArgument)
            {
                MessageBox.Show("Error in Argument Exception " + eArgument.Message);
            }
            catch (InvalidOperationException eInvalidOperation)
            {
                MessageBox.Show("Error in invalid Operation Exception " + eInvalidOperation.Message);
            }
            this.Dispose();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void runtxt_KeyDown(object sender, KeyEventArgs e)
        {
            //if(K
        }
    }
}