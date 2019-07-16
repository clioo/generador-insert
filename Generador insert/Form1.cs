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
            Excel.Application app = new Excel.Application();
            //Excel.Workbook workBook = new Excel.Workbooks.Open(this.archivo);
            //Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            //Excel.Range xlRange = xlWorksheet.UsedRange;
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            string str;
            string[] ecabezados = new string[] { };
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;
            ecabezados = obtenerEncabezado( Int32.TryParse(txt_encabezado.Text));
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(this.archivo, 
                0, true, 5, "", "", true, 
                Microsoft.Office.Interop.Excel.XlPlatform.xlWindows,
                "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item("Hoja1");
            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;
            MessageBox.Show(rw.ToString());
            MessageBox.Show(cl.ToString());
            
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
        
        private void obtenerEncabezado(int row)
        {
            
        }
    }
}
