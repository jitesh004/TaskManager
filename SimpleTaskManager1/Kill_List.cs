using System;

using System.Windows.Forms;

using System.Xml;





namespace SimpleTaskManager1
{
    public partial class Kill_List : Form
    {

        #region Diclaration
        private int noOfProcess;
        private string[] ProcessNames;
        public string[] PInKill_List;
        private string fullstring;
        private XmlTextReader reader;
        private int noOfTageExist;
        private bool check = true;
        private string title;
        private string filename;
        private bool save_Click=true;

        // data of the text box in both Kill List and Except List
       
        private string KillData;
        #endregion

        public Kill_List()
        {
            InitializeComponent();
        }

        public Kill_List(string window_name)
        {

            InitializeComponent();
            
            if (window_name == "Kill List") 
            {
                title = window_name;
                this.Text = title;
               // MessageBox.Show("Entered in Kill List");
                ReadXmlFile("Kill List.xml");
                KillData = this.txtbox.Text;
                filename = "Kill List.xml";
            }
            
        }

        public void AddOneToList()
        {
            noOfProcess++;
            save_Click = false;
            //MessageBox.Show(" Add One is one");
        }
        public void AddOneToList(string fname)
        {
            filename = fname;
            noOfProcess++;
            save_Click = false;
            
        }

        public int TotalTages()
        {
            return noOfProcess + noOfTageExist;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1(sender);
            try
            {
                fullstring = txtbox.Text;
                ProcessNames = ConvertStringToStringArray(fullstring);
                fm.save(filename, ProcessNames, TotalTages());
                save_Click = true;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error while saving : "+ex.Message,
                    "Error while saving",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           

            
        }
        #region Check in exceptList

       
        #endregion


        private string[] ConvertStringToStringArray(string mystring)
        {
            char[] ch = new char[] { '\n' };
            string[] stringArray = new string[100];
            stringArray = mystring.Split(ch, StringSplitOptions.None);

            return stringArray;
        }

         
        public void ReadXmlFile(string filename)
        {
            try
            {
                reader = new XmlTextReader(filename);//,new System.Text.UTF8Encoding());
                reader.WhitespaceHandling = System.Xml.WhitespaceHandling.None;
                PInKill_List = new string[100];
                bool bEnableProcessNamesContent = false;
                bool bEnableProcessContent = false;
                int i = 0;
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case System.Xml.XmlNodeType.Element:
                            bEnableProcessNamesContent = (reader.Name == "PorecessNames");
                            bEnableProcessContent = (reader.Name == "Process");
                            break;
                        case System.Xml.XmlNodeType.Text:
                            //  ListViewItem lvi = new ListViewItem(reader.Value);
                            txtbox.Text += reader.Value + "\n";
                            PInKill_List[i] = reader.Value;
                            PInKill_List[i] = PInKill_List[i].TrimEnd('\r');
                            if (check)
                                noOfTageExist++;

                            i++;
                            //lv2.Items.Add(reader.Value);
                            //   this.lv2.Items.AddRange(new ListViewItem[] { lvi });

                            break;
                    }

                }
                check = false;
                reader.Close();
                
            }
            catch (Exception)
            {
                
                reader.Close();
            }
        }

        private void Kill_List_is_Closing(object sender, FormClosingEventArgs e)
        {
            if (!save_Click)
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to save added list ","Saving option",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                    savebtn_Click(sender, e);
            }
        }

    }
}