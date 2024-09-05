using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace HẹThongQuanLyNhanVien.SERVICE
{
    public class function
    {
        public static void mess(string str)
        {
            MessageBox.Show(str);
        }
        public static string convert_YYYY_MM_DD(DateTime value)
        {
            return value.ToString("yyyy-MM-dd");
        }
        public static string curentDate()
        {
            DateTime now = DateTime.Now;
            return $"{now.Year}-{now.Month}-{now.Day}";
        }
        public static int ChangeStrToNumber(string str)
        {
            return Convert.ToInt32(Regex.Replace(str,"[^0-9]",""));
        }
        public static string ChangeMoney(int number)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            return number.ToString("N0", culture);
        }
        public static string TachngayThangNam(string str)
        {
            string format = "dd/MM/yyyy h:mm:ss tt";
            DateTime time = DateTime.ParseExact(str, format, null);
            return $"{time.Year}-{time.Month}-{time.Day}";
        }
        public static string TachngayThangNamDoanhThu(string str)
        {
            string format = "dd/MM/yyyy hh:mm:ss tt";
            DateTime time = DateTime.ParseExact(str, format, null);
            return time.ToString("yyyy-MM-dd");
        }
        public static void ExportExcels(string path,DataGridView table)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < table.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = table.Columns[i].HeaderText;
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (table.Rows[i].Cells[j].Value != null)
                    {
                        application.Cells[i + 2, j + 1] = table.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Cell value is null" + $"{i}-{j}");
                    }

                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        public static int checkCharacter(string str)
        {
            string[] slice = str.Split('-');
            if(slice.Length > 0)
            {
                return slice.Length;
            }
            return 0;
        }
        public static void ExportPdf(DataGridView table)
        {
            if (table.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(table.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in table.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in table.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    if (dcell.Value != null && !string.IsNullOrEmpty(dcell.Value.ToString()))
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                    
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
   
    }
}
