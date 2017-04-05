using Microsoft.Win32;
using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace SimpleTaskManager1
{
    public partial class SystemMonitor : Form
    {
        RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
        SpeechSynthesizer sp = new SpeechSynthesizer();
        int fcpu;
        int fRAM;
        int fDisk;
        float minute;
        float hour;
        string pathName;
        public SystemMonitor()
        {
            InitializeComponent();
        }
        private void LoadProperties()
        {
            try
            {
                pathName = (string)registryKey.GetValue("productName");
                lblOS.Text = pathName;
                fcpu = (int)perfCPU.NextValue();
                labelCPU.Text = string.Format("{0:0}%", fcpu);
                proCPU.Value = (int)fcpu;
                fRAM = (int)perfRAM.NextValue();
                labelRAM.Text = string.Format("{0:0}%", fRAM);
                proRAM.Value = (int)fRAM;
                fDisk = (int)perfDisk.NextValue();
                labelDisk.Text = string.Format("{0:0}%", fDisk);
                proDisk.Value = (int)fDisk;
                minute = (perfSystem.NextValue() / 60) % 60;
                hour = perfSystem.NextValue() / 60 / 60;
                lblSystem.Text = "System Up Time:" + " " + (int)hour+ " Hours" + " " + (int)minute + " minutes";
            }
            catch(Exception)
            {

            }
        }
        private void Speeches()
        {
            
            try
            {
                
                sp.Rate = 2;
                sp.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
                
                sp.Speak("Your Operating system is " + pathName);
                sp.Speak("Your CPU usage is" + fcpu + "Percent");
                sp.Speak("Your RAM usage is" + fRAM + "Percent");
                sp.Speak("Your Disk usage is" + fDisk + "Percent");
                sp.Speak("Your system is up from " + (int)hour + " Hours " + (int)minute + " minutes");
                
            }
            catch (Exception)
            {

            }
            
            bu = false;
        }

        
        private void SystemMonitor_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
     
        public void some(Boolean b)
        {
     
            if (b == true)
            {
                Speeches();
     
            }
     
            else
                LoadProperties();
        }
        Boolean bu;
        private void timer_Tick(object sender, EventArgs e)
        {
           
            some(bu);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bu = true;
           
            some(bu);
            
        }
        
    }
}
