﻿using DSS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DSS.Controller
{
    public class CLuat
    {
        String tableName = "tbLuat";
        String columnsName = "ID, Name";
        MyDataAccess da = new MyDataAccess();

        public DataTable SelectAll()
        {
            String query = "Select * From " + tableName;
            return da.Read(query);
        }

        public DataTable SelectAll(String condition)
        {
            String query = "Select * From " + tableName;
            if (condition.Length > 0)
                query += " Where " + condition;
            return da.Read(query);
        }

        public List<MLuat> SelectAllList()
        {
            DataTable tb = SelectAll();
            if (tb != null)
            {
                List<MLuat> ds = new List<MLuat>();
                foreach (DataRow r in tb.Rows)
                {
                    MLuat m = new MLuat();
                    m.ID = int.Parse(r["ID"].ToString());
                    m.Name = r["Name"].ToString();
                    m.Description = r["Description"].ToString();
                    m.RightID = int.Parse(r["RightID"].ToString());
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }

        public List<MLuat> SelectAllList(String condition)
        {
            DataTable tb = SelectAll(condition);
            if (tb != null)
            {
                List<MLuat> ds = new List<MLuat>();
                foreach (DataRow r in tb.Rows)
                {
                    MLuat m = new MLuat();
                    m.ID = int.Parse(r["ID"].ToString());
                    m.Name = r["Name"].ToString();
                    m.Description = r["Description"].ToString();
                    m.RightID = int.Parse(r["RightID"].ToString());
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }


        public MLuat GetByID(String id)
        {
            List<MLuat> ds = SelectAllList("ID=" + id);
            if (ds != null && ds.Count > 0)
                return ds[0];
            else
                return null;
        }


        public Boolean Exist(String name)
        {
            DataTable tb = SelectAll("Name=N'" + name + "'");
            if (tb == null)
                return false;
            else
                return true;
        }

        public Boolean ExitRight(String rightID)
        {
            DataTable tb = SelectAll("RightID=" + rightID);
            if (tb == null)
                return false;
            else
                return true;
        }

        public int GetLastID()
        {
            String query = "Select Top 1 ID From " + tableName + " Order By ID DESC";
            DataTable tb = da.Read(query);
            if (tb != null)
            {
                return int.Parse(tb.Rows[0][0].ToString());
            }
            else
                return -1;
        }

        public int Insert(String name, String description, int rightID, List<MMenhDe> left)
        {
            if (!Exist(name))
            {
                String query = "Insert Into " + tableName + "(Name, Description, RightID) Values(N'"
                    + name + "',N'"
                    + description + "',"
                    + rightID.ToString() + ")";
                int dem = da.Write(query);
                if(dem == 1)
                {
                    // Cap nhat chi tiet luat
                    CChiTietLuat cct = new CChiTietLuat();
                    int lastID = GetLastID();
                    foreach(MMenhDe m in left)
                    {
                        cct.Insert(lastID, m.ID);
                    }    
                }
                return 1;
            }
            else
                return 0;
        }

        public int Insert(MLuat luat)
        {
            if (!Exist(luat.Name))
            {
                String query = "Insert Into " + tableName + "(Name) Values(N'"
                    + luat.Name + "',N'"
                    + luat.Description + "',"
                    + luat.RightID.ToString() + ")";
                return da.Write(query);
            }
            else
                return 0;
        }

        public int Update(int id, String name, String description, int rightID)
        {
            String query = "Update " + tableName + " Set Name=N'"
                + name + "', Description=N'"
                + description + "', RightID="
                + rightID + " Where ID=" + id;
            return da.Write(query);
        }

        public int Update(MLuat luat)
        {
            String query = "Update " + tableName + " Set Name=N'"
                + luat.Name + "', Description=N'"
                + luat.Description + "', RightID="
                + luat.RightID.ToString() + " Where ID=" + luat.ID;
            return da.Write(query);
        }

        public int Delete(int id)
        {
            String query = "Delete " + tableName + " Where ID=" + id;
            return da.Write(query);
        }

        public int Delete(String condition)
        {
            String query = "Delete " + tableName + " Where " + condition;
            return da.Write(query);
        }
    }
}
