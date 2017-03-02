using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Web;
using NUglify;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;

namespace JIRA
{
    public class Issue
    //Create C# class to meet json object , to post this json into rest API
    {

     
        public Fields fields { get; set; }
        public Issue()
        {
            fields = new Fields();
        }
    }

    public class Fields
    {
        public Project project { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public IssueType issuetype { get; set; }
        public Fields()
        {
            project = new Project();
            issuetype = new IssueType();
        }
    }

    public class Project
    {
        public string key { get; set; }
    }

    public class IssueType
    {
        public string name { get; set; }
    }

    /* /* NNow we will create object with (Issue) and then we will fill it with needed info , this we wil lserialize it and pass it to rest API */

    class Program
    {

        static void Main(string[] args)
        {
         
            ReadFile r = new ReadFile();
             string bug = r.ReadTrxFile();
        
            var data = new Issue();
            data.fields.project.key = "EM";
            data.fields.summary = "Bug" + " " + DateTime.Now;
            data.fields.description = bug;
            data.fields.issuetype.name = "Bug";

            // string postUrl = "http://testagent.southeastasia.cloudapp.azure.com:7000/rest/api/latest/issue";

            string postUrl = "http://devopsjira.southeastasia.cloudapp.azure.com/rest/api/latest/issue";

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

            client.BaseAddress = new System.Uri(postUrl);
          //  byte[] cred = UTF8Encoding.UTF8.GetBytes("Priyanka:Ult1m@te");
            byte[] cred = UTF8Encoding.UTF8.GetBytes("Abhideep:London@123");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(cred));
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            System.Net.Http.Formatting.MediaTypeFormatter jsonFormatter = new System.Net.Http.Formatting.JsonMediaTypeFormatter();

            //System.Net.Http.HttpContent content = new System.Net.Http.ObjectContent<string>(data, jsonFormatter);
            System.Net.Http.HttpContent content = new System.Net.Http.ObjectContent<Issue>(data, jsonFormatter);
            System.Net.Http.HttpResponseMessage response = client.PostAsync("issue", content).Result;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result; // its will be 200 OK (inserted)
                Console.Write(result);
            }
            else
            {
                Console.Write(response.StatusCode.ToString());
                Console.ReadLine();
            }
        }
    }
}
