
using System.IO;
using System.Xml;

namespace SimpleTaskManager1
{
    partial class Form1
    {
        private XmlTextWriter writer;
       // private object sender;

        

        private void ConformXmlFile()
        {
            XmlTextReader myreader = new XmlTextReader("Kill List.xml");

            if (!File.Exists("Kill List.xml"))
            {
                CreateXmlFile("Kill List.xml");
            }
            
        }

        public void CreateXmlFile(string filepath)
        {

            writer = new XmlTextWriter(filepath, new System.Text.UTF8Encoding());
            writer.Formatting = System.Xml.Formatting.Indented;

            writer.Close();
        }

        #region Saving Funtion
        public void save(string filename, string[] kill_list, int noOfkill)
        {

            try
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("ProcessNames");
            }
            catch
            {
                writer = writer = new XmlTextWriter(filename, new System.Text.UTF8Encoding());
                writer.WriteStartDocument();
                writer.WriteStartElement("ProcessNames");

            }
            for (int i = 0; i < noOfkill; i++)
            {
                writer.WriteStartElement("process"); // i,e <process>
                writer.WriteString(kill_list[i]);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();
        }
        #endregion

       
    }

}
