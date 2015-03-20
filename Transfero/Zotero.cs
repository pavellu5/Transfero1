using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace Transfero
{
    class Zotero
    {
        SQLiteConnection connection;

        public Zotero()
        {
            connection = new SQLiteConnection("Data Source=D:\Zotero\zotero.sqlite;Version=3;");
            connection.Open();
        }




    }
}
