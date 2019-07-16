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

namespace Generador_insert
{
    public partial class Form1 : Form
    {
        public string archivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Cmd_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\DELL\Documents\innovacion\seguimientometas\documentacion";
            ofd.Title = "Escoge un archivo excel";
            ofd.DefaultExt = ".xlsx";
            ofd.Filter = "Excel (*.xlsx)|*.xlsx|Excel anterior a 2007 (*.xls)|*.xls|Todos los archivos (*.*)|*.*";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.ShowDialog();
            foreach (String file in ofd.FileNames)
            {
                txt_path.Text = file;
                this.archivo = file;
            }
        }

        private void Txt_encabezado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //if (txt_encabezado.Text == "")
            //{
            //    MessageBox.Show("Se necesita fila de encabezados.");
            //}
            //else if (txt_filafinal.Text == "")
            //{
            //    MessageBox.Show("Se necesita fila final.");

            //}
            //else if (txt_nombrehoja.Text == "")
            //{
            //    MessageBox.Show("Se necesita nombre de la hoja.");
            //}
            //else if (txt_tabla.Text == "")
            //{
            //    MessageBox.Show("Se necesita nombre de la hoja.");
            //}
            //else
            //{

            //}
            Excel.Application app = new Excel.Application();
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            string str;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;
            
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(this.archivo, 
                0, true, 5, "", "", true, 
                Microsoft.Office.Interop.Excel.XlPlatform.xlWindows,
                "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(txt_nombrehoja.Text.ToString());
            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;
            //Aquí va el encabezado de la base de datos
            string[] encabezados = new string[cl - 1];
            //trabajamos con los encabezados

            for (int i = 1; i < cl; i++)
            {
                encabezados[i -1] = (string)(range.Cells[Int32.Parse(txt_encabezado.Text), i] as Excel.Range).Value2;
            }


            //for (int i = 0; i < rw; i++)
            //{
            //    str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;

            //}

            //for (rCnt = 1; rCnt <= rw; rCnt++)
            //{
            //    for (cCnt = 1; cCnt <= cl; cCnt++)
            //    {
            //        str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
            //        MessageBox.Show(str);
            //    }
            //}
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
        }
    }
}
