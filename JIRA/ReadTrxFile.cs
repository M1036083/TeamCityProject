using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JIRA
{
    
    public class ReadFile
    {

        public string ReadTrxFile()
        {

          // var directory = new DirectoryInfo(@"C:\Results\CodedUITestProject2\10212016\201610211056Result");//vmvs
       var directory = new DirectoryInfo(@"C:\Jenkins_WorkSpace\EmployeeProject_Build\workspace\SeleniumTestResults");//testagent
        var newestFile = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
          
            string result = null;
            string element = "";
            using (XmlReader xmlReader = new XmlTextReader(newestFile.FullName))
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element)
                    {
                        element = xmlReader.Name;
                    }
                    else if (xmlReader.NodeType == XmlNodeType.Text)
                    {
                        switch (element)
                        {

                            case "Message":
                                result = xmlReader.Value;

                                Console.WriteLine(result);
                                break;

                        }
                    }
                }
            }
           
            return result;
        }

        
        
    }
   
}
