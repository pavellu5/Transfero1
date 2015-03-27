using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Transfero
{
    class Zotero
    {
        private string path = @"connection.txt";
        private string web = "https://api.zotero.org/groups/";
        private string groupID = "";
        private string collectionID = "";
        private string key = "";
        
        private string link;

        public Zotero()
        {
            if (LoadConnection() == false)
            {
                Connection conn = new Connection(path);
                conn.Show();
                LoadConnection();
            }


            link = web + groupID + "/items?key=" + key;
            System.IO.File.WriteAllText(@"D:\link.txt", link);
            //link = "https://api.zotero.org/groups/326176/items?key=hRGHCO10Yk9hCeCc8DMuyGmo";
        }

        public string GetPath()
        {
            return path;
        }

        public bool LoadConnection()
        {
            Boolean ret = true;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                groupID = file.ReadLine();
                collectionID = file.ReadLine();
                key = file.ReadLine();
                file.Close();
            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        public bool NewSample()
        {
            bool ret = true;
            
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.Timeout = 20000;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "[{ \"itemType\": \"book\", \"title\": \"book from c# no.3\",\"creators\":" +
                    "[{\"creatorType\": \"author\",\"firstName\": \"lukas\",\"lastName\": \"pavelka\"}],\"abstractNote\": \"something\",\"series\": \"\"," +
                    "\"seriesNumber\": \"\",\"volume\": \"\",\"numberOfVolumes\": \"\",\"edition\": \"\",\"place\": \"\",\"publisher\": \"\",\"date\": \"\"," +
                    "\"numPages\": \"\",\"language\": \"\",\"ISBN\": \"\",\"shortTitle\": \"\",\"url\": \"\",\"accessDate\": \"\",\"archive\": \"\",\"archiveLocation\": \"\"," +
                    "\"libraryCatalog\": \"\",\"callNumber\": \"\",\"rights\": \"\",\"extra\": \"\",\"tags\": [ ],\"collections\": [\"" + collectionID + "\"],\"relations\": { }}]";

                //string json = System.IO.File.ReadAllText(@"D:\json.txt");
               // System.IO.File.WriteAllText(@"D:\WriteText.txt", json);
                streamWriter.Write(json);
            }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    System.IO.File.WriteAllText(@"D:\responcse.txt", responseText);
                    
                }
            }
            catch
            {
                ret = false;
                //MessageBox.Show("Conection to Zotero isn't working.\rCheck Conection settings.");
            }

            return ret;
        }
    }
}
