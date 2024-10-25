using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class General_class
    {

    public General_class()
    {
        // constarctor
        createfileStudents();
        createfileEmployee();
    }
    public Hashtable gethash()
    {
        Hashtable hash = new Hashtable();
        hash.Add("id", 1);
        hash.Add("name", "Hisham bakr");
        hash.Add("date", DateTime.Now);

        return hash;
    }
    public DataTable dtGetEmployees()
    {
        DataTable dt;
        dt = new DataTable();
        DataRow dr;
        //create Columns
        dt.Columns.Add("ID");
        dt.Columns.Add("name");
        dt.Columns.Add("Country");
        //create rows
        dr = dt.NewRow();
        dr[0] = "1";
        dr[1] = "Hisham Bakr";
        dr[2] = "Egypt";
        dt.Rows.Add(dr);
        //create rows
        dr = dt.NewRow();
        dr[0] = "2";
        dr[1] = "Mohammed";
        dr[2] = "Saudi arabia";
        dt.Rows.Add(dr);

        return dt;
    }

    public void createfileStudents()
    {
        string path = "C:\\test";
        string pathFile = "C:\\test\\students.txt";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        //craete file
        using (StreamWriter writer = new StreamWriter(pathFile))
        {
            writer.WriteLine("Mohammed degree : 500");
            writer.WriteLine("Ahmed degree : 1000");
        }
    }
    public void createfileEmployee()
    {
        string path = "C:\\test";
        string pathFile = "C:\\test\\salary.txt";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        //craete file
        using (StreamWriter writer = new StreamWriter(pathFile))
        {
            writer.WriteLine("5500");
        }
    }
    public void copyStudents()
    {
        string pathFile = "C:\\test\\students.txt";
        string pathFileTo = "C:\\test\\note2.txt";
        File.Copy(pathFile, pathFileTo, true);
    }

    public string readfileStudents()
    {
        string pathFile = "C:\\test\\students.txt";
        string text = File.ReadAllText(pathFile);

        return text;
    }
    public int readfileEmployee()
    {
        string pathFile = "C:\\test\\salary.txt";
        string text = File.ReadAllText(pathFile);

        int salary = 0;
        int.TryParse(text, out salary);

        return salary;
    }

}
 
