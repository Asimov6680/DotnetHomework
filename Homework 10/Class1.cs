using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{

    public class SimpleCrawler0
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private string message = "";
        Task[] tasks = new Task[100];
        public Hashtable Urls
        {
            get => urls;
        }
        public Task[] Tasks
        {
            get=>tasks;
        }

        public string Message
        {
            get => message;
        }

        public void Crawl()
        {
            message += "开始爬行了.... \r\n";

            while (true)
            {
                string current = null;
                
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]==true) continue;
                    current = url;
                }

                if (current == null || count > 10)
                {
                    break;
                }
                tasks[count] = Task.Run(() =>
                {

                    string currentUrl = current;
                    string currentMessage = "";
                    string currentHTML = "";
                   
                    currentMessage += ("爬行" + currentUrl + "页面!\r\n");
                    currentHTML = DownLoad(currentUrl); // 下载

                   
                    lock (this)
                    {
                        urls[currentUrl] = true;
                        count++;
                        Parse(currentHTML, currentUrl);//解析,并加入新的链接
                        currentMessage += "爬行结束\r\n";
                        message += currentMessage;
                    }
                    message += currentMessage;                   
                });
              
                
            }
            
            message += "爬行完毕";
            
        }

        
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                
                return html;
            }
            catch (Exception ex)
            {
                message += ex.Message;
                message += "\r\n";
                //Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string parentUri)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                Uri u1 = new Uri(parentUri);
                Uri u2 = new Uri(u1, strRef);
                strRef = u2.ToString();
                bool IsMatch = Regex.IsMatch(strRef, @"(html|shtml|jsp|aspx)$");
                if (strRef.Length == 0 || !IsMatch) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
