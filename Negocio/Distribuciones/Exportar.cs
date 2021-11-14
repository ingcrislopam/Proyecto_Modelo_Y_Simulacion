using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Distribuciones
{
    public class Exportar
    {
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int c = 1; c < grd.Columns.Count + 1; c++)
                {
                    hoja_trabajo.Cells.Item[1, c] = grd.Columns[c - 1].Name.ToString();
                }
                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    //En grd.Columns.Count iva un -1
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                hoja_trabajo.Rows.Item[1].Font.Bold = 1;
                hoja_trabajo.Rows.Item[1].HorizontalAlignment = 3;
                hoja_trabajo.Columns.AutoFit();
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        //public bool llenarExcel(DataGridView ElGrid)
        //{
        //    Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
        //    Microsoft.Office.Interop.Excel.Workbook exLibro = default(Microsoft.Office.Interop.Excel.Workbook);
        //    Microsoft.Office.Interop.Excel.Worksheet exHoja = default(Microsoft.Office.Interop.Excel.Worksheet);
        //    try
        //    {
        //        exLibro = exApp.Workbooks.Add();
        //        exHoja = exLibro.Worksheets.Add();
        //        int NCol = ElGrid.ColumnCount;
        //        int NRow = ElGrid.RowCount;

        //        for (int i = 1; i <= NCol; i++)
        //        {
        //            exHoja.Cells.Item[1, i] = ElGrid.Columns[i - 1].Name.ToString();
        //        }

        //        for (int Fila = 0; Fila <= NRow - 1; Fila++)
        //        {

        //            for (int Col = 0; Col <= NCol - 1; Col++)
        //            {
        //                exHoja.Cells.Item[Fila + 2, Col + 1] = ElGrid[Col, Fila].Value;
        //            }
        //        }
        //        exHoja.Rows.Item[1].Font.Bold = 1;
        //        exHoja.Rows.Item[1].HorizontalAlignment = 3;
        //        exHoja.Columns.AutoFit();
        //        exApp.Application.Visible = true;
        //        exHoja = null;
        //        exLibro = null;
        //        exApp = null;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error al exportar a Excel");
        //        return false;
        //    }
        //    return true;
        //}

    }
}
