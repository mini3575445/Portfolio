using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Match.Controllers
{
    public class ActivityMessage
    {
        string path = @"D:\School\SchoolVM\網站資訊系統\VS\WebApp\Match\ActivityMessage\";

        public void Write(string activityID, string member_name, string text)
        {
            path = path + activityID + ".txt";                        
            if (!System.IO.File.Exists(path))
            {                
                using (StreamWriter sw = System.IO.File.CreateText(path)){}
            }
                        
            using (StreamWriter sw = System.IO.File.AppendText(path))
            {
                sw.WriteLine(member_name+ "："+text+"　　"+ DateTime.Now);
            }
        }

        public List<string> Read(string activityID)
        {
            path = path + activityID + ".txt";
            List<string> result = new List<string>();

            if (System.IO.File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        result.Add(line);
                    }
                }
            }            
            return result;
        }



    }
}