using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Collections;
using System.Data;

namespace Transfero
{
    class Command
    {
        SQLiteConnection m_dbConnection;

        public Command()
        {
            m_dbConnection = new SQLiteConnection("Data Source=data.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        //execute command from agument of method
        public bool Execute(String text) 
        {
            bool ret = true;
            try
            {
                string sql = text;
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        //returned values from reader - executing commands from agrument
        public ArrayList Reader(string text)
        {
            string sql = text;
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            ArrayList values = new ArrayList();
            while (reader.Read())
            {
                values.Add(reader.GetString(0));
            }
            return values;
        }

        public DataTable GetData(string text)
        {
            DataTable data = new DataTable();

            SQLiteCommand cmd = new SQLiteCommand(text, m_dbConnection);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            
            da.SelectCommand = cmd;
            da.Fill(data);

            return data;
        }


        //execute new transfer of sample
        public bool NewTransfer(string username, string sample, string location)
        {
            bool ret = true;
            try
            {
                //create new record in table transfers
                string sql1 = "insert into transfers (transfer_date, username, id_sample, name_sample, id_location, name_location) values (Date('now'), '" + username
                    + "', (select id from samples where name = '" + sample + "'), '" + sample
                    + "', (select id from locations where name = '" + location + "'), '" + location + "')";
                SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);
                command1.ExecuteNonQuery();

                //update current_location of transfered sample (in table samples)
                string sql2 = "update samples set current_location = '" + location + "' where name = '" + sample + "'";
                SQLiteCommand command2 = new SQLiteCommand(sql2, m_dbConnection);
                command2.ExecuteNonQuery();
            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        public bool NewSample(string name, string location, string origin, string description, string weblink)
        {
            bool ret = true;
            try
            {
                //create new record in table transfers
                string sql1 = "insert into samples (name, current_location, origin, description, weblink) values ('" + 
                    name + "', '" + location + "', '" + origin + "', '" + description + "', '" + weblink + "')";
                SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);
                command1.ExecuteNonQuery();

            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        public bool NewLocation(string location)
        {
            bool ret = true;
            try
            {
                //create new record in table transfers
                string sql1 = "insert into locations (name) values ('" + location + "')";
                SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);
                command1.ExecuteNonQuery();
            }
            catch
            {
                ret = false;
            }
            return ret;
        }


        public void Close()
        {
            m_dbConnection.Close();
        }


    }
}
