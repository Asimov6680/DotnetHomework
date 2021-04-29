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
    

    public class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private string exceptionMessage;
        public Hashtable Urls
        {
            get => urls;
        }

        public string ExceptionMessage
        {
            get => exceptionMessage;
        }

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10)
                {

                    break;
                }
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载

                urls[current] = true;
                count++;
                Parse(html, current);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
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
                exceptionMessage += ex.Message;
                exceptionMessage += "\n";
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
    public class SimpleCrawler0
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private string message = "";
        
        public Hashtable Urls
        {
            get => urls;
        }

        public string Message
        {
            get => message;
        }

        public void Crawl()
        {
            message += "开始爬行了.... \n";
            
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10)
                {

                    break;
                }
                message += ("爬行" + current + "页面!\n");
                string html = DownLoad(current); // 下载

                urls[current] = true;
                count++;
                Parse(html, current);//解析,并加入新的链接
                message+="爬行结束\n";
            }
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
                message += "\n";
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
