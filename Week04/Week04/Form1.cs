using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Data.Entity.Migrations.Model;

namespace Week04
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> Flats;
        Excel.Application xlApp;
        Excel.Workbook xlWb;
        Excel.Worksheet xlWs;
             
        public Form1()
        {
            InitializeComponent();
            Loaddata();
            CreateExcel();
        }

        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWb = xlApp.Workbooks.Add(Missing.Value);
                xlWs = xlWb.ActiveSheet;
                CreateTable();
                xlApp.Visible = true;
                xlWb.UserControl = true;

            }
            catch (Exception ex)
            {
                String errmsg = String.Format("Error: {0}\nline: {1}", ex.Message, ex.Source);
                MessageBox.Show(errmsg,"Error");
                xlWb.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWb = null;
                xlApp = null;
            }
        }

        private void CreateTable()
        {
            throw new NotImplementedException();
        }

        private void Loaddata()
        {
            var Headers = new string[]
            {
                "Kód",
                "Eladó",
                "Oldal",
                "Kerület",
                "Lift",
                "Szobák száma",
                "Alapterület (m2)",
                "Ár (Mft)",
                "Négyzetméter ár (Ft/m2)"
            };
            for (int i = 0; i < Headers.Length; i++)
            {
                xlWs.Cells[1, i + 1] = Headers[i];
            }
            object[,] values = new object[Flats.Count, Headers.Length];
            int counter = 0;
            foreach (var f in Flats)
            {

            }
        }
    }
}
