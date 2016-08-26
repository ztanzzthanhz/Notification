using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ConsoleApplication1
{
    public class cUrl
    {
        public static void Exec(string jsonData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://android.googleapis.com/gcm/send");
            request.Method = "POST";
            request.Accept = "*/*";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "key=AIzaSyDVc9XeqiDroCgyin0WHJPha8V8sSLAdAo");            

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                // we want to remove new line characters otherwise it will return an error
                jsonData = jsonData.Replace("\n", "");
                jsonData = jsonData.Replace("\r", "");
                streamWriter.Write(jsonData);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
                string respStr = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                Console.WriteLine("Response : " + respStr); // if you want see the output
            }
            catch (Exception ex)
            {
                //process exception here   
            }
        }
    }
}
