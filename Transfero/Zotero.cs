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
        private int timeout = 4000;

        private string web = "https://api.zotero.org/groups/";
        private string groupID = "";
        private string collectionID = "";
        private string key = "";
        
        private string itemLink;
        private string collectionLink;

        public Zotero()
        {
            if (LoadConnection() == false)
            {
                Connection conn = new Connection(path);
                conn.Show();
                LoadConnection();
            }
            itemLink = web + groupID + "/items?key=" + key;
            collectionLink = web + groupID + "/collections?key=" + key;
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

        //CREATE NEW ITEM
        public string NewSample(string name, string location, string origin, string description, string weblink, string collectionKey)
        {
            string ret;
            
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(itemLink);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.Timeout = timeout;
            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "[{\"itemType\": \"letter\",\"title\": \"" + name + "\",\"creators\": [{\"creatorType\": \"author\",\"firstName\": \"\",\"lastName\": \"" + origin + "\"}]," +
                    "\"abstractNote\": \"" + description + "\",\"letterType\": \"\",\"date\": \"\",\"language\": \"\",\"shortTitle\": \"\",\"url\": \"" + weblink + "\"," + 
                    "\"accessDate\": \"\",\"archive\": \"\",\"archiveLocation\": \"\",\"libraryCatalog\": \"\"," +
                    "\"callNumber\": \"\",\"rights\": \"\",\"extra\": \"\",\"tags\": [\"" + location + "\"],\"collections\": [\"" + collectionKey + "\"],\"relations\": { }}]";
                    //System.IO.File.WriteAllText(@"D:\WriteText.txt", json);
                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    //System.IO.File.WriteAllText(@"D:\responcse.txt", responseText);
                    ret = GetKey(responseText);
                }
            }
            catch
            {
                ret = "";
            }
            return ret;
        }

        //CREATE NEW COLLECTION
        public string NewLocation(string name)
        {
            string ret;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(collectionLink);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.Timeout = timeout;
            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "[{\"name\" : \"" + name + "\",\"parentCollection\" : \"\"}]";
                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    //System.IO.File.WriteAllText(@"D:\responcse.txt", responseText);
                    ret = GetKey(responseText);
                }
            }
            catch
            {
                ret= "";
            }
            return ret;
        }

        //UPDATE ITEM (TRANSFER)
        //change a tag and collection of item
        public bool Transfer(string itemKey, string collectionKey, string locationName)
        {
            bool ret = true;
            string link = web + groupID + "/items/" + itemKey + "?key=" + key;
            string versionLine = GetVersion(itemKey);

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PATCH";
            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.Timeout = timeout;
            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"key\": \"" + itemKey + "\"," + versionLine + "\"tags\": [\"" + locationName + "\"],\"collections\": [\"" + collectionKey + "\"]}";
                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                }
            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        //return version of item
        private string GetVersion(string itemKey)
        {
            string ret;
            string link = web + groupID + "/items/" + itemKey + "?key=" + key;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.Timeout = timeout;
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    //System.IO.File.WriteAllText(@"D:\responcse.txt", responseText);
                    ret = SeparateVersion(responseText);
                }
            }
            catch
            {
                ret = "";
            }
            return ret;
        }

        private string SeparateVersion(string response)
        {
            string ret = "";
            int first = response.IndexOf("\"version\"");
            int last = response.LastIndexOf("\"library\"");
            ret = response.Substring(first, last - first);
            //System.IO.File.WriteAllText(@"D:\itemversion.txt", ret);
            return ret;
        }


        //separate item or collection key from api response
        private string GetKey(string response)
        {
            string ret = "";
            ret = response.Substring(33, 8);
            //System.IO.File.WriteAllText(@"D:\itemkey.txt", ret);
            return ret;
        }

    }
}
