using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Pdf;
using iText.Layout.Element;


namespace SPA_ARUMA.Forms
{
    public partial class Reportes : Form
    {
        private PrintDocument PD = new PrintDocument();
        private PrintPreviewDialog PPD = new PrintPreviewDialog();
        private int longpaper;


        public Reportes()
        {
            InitializeComponent();
            PD.BeginPrint += new PrintEventHandler(PD_BeginPrint);
            PD.PrintPage += new PrintPageEventHandler(PD_PrintPage);
        }


        private void PD_BeginPrint(object sender, PrintEventArgs e)
        {
            PageSettings pagesetup = new PageSettings();
            pagesetup.PaperSize = new PaperSize("Custom", 725, longpaper);
            PD.DefaultPageSettings = pagesetup;
        }

        private string InsertLineBreaks(string input, int interval)
        {
            for (int i = interval; i < input.Length; i += interval + 1)
            {
                input = input.Insert(i, "\n");
            }
            return input;
        }

        private int CalculateLineBreakHeight(string input, int interval, int lineHeight)
        {
            int lineBreaks = (input.Length / interval);
            return lineBreaks * lineHeight;
        }

        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font f8 = new Font("Palatino Linotype", 12, FontStyle.Regular);
            Font f10 = new Font("Palatino Linotype", 10, FontStyle.Regular);
            Font f101 = new Font("Palatino Linotype", 6, FontStyle.Regular);
            Font f10b = new Font("Palatino Linotype", 12, FontStyle.Bold);
            Font f14 = new Font("Palatino Linotype", 14, FontStyle.Bold);

            int leftmargin = PD.DefaultPageSettings.Margins.Left;
            int centermargin = PD.DefaultPageSettings.PaperSize.Width / 2;
            int rightmargin = PD.DefaultPageSettings.PaperSize.Width;


            StringFormat right = new StringFormat();
            StringFormat center = new StringFormat();
            StringFormat left = new StringFormat();
            right.Alignment = StringAlignment.Far;
            center.Alignment = StringAlignment.Center;
            left.Alignment = StringAlignment.Near;

            string line = "______________________________________________________________________________________________________________________________";

            System.Drawing.Image logoImage = Properties.Resources.logo_ticket;
            e.Graphics.DrawImage(logoImage, (e.PageBounds.Width - 50) / 2, 5, 55, 20);

            e.Graphics.DrawString("ARUMA", f10, Brushes.Black, centermargin, 27, center);
            e.Graphics.DrawString("Ignacio Altamirano 7A Col.Ex-Hacienda De Santa Monica,", f101, Brushes.Black, 215, 45);
            e.Graphics.DrawString("Tlanepantla De Baz,Estado De México C.P 54050.", f101, Brushes.Black, 230, 55);
            e.Graphics.DrawString("REPORTE DE VENTAS", f8, Brushes.Black, 520, 10);

            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString() + " - Hora: " + DateTime.Now.ToShortTimeString(), f8, Brushes.Black, 0, 75);

            e.Graphics.DrawString("Id", f8, Brushes.Black, 4, 110);
            e.Graphics.DrawString("Nom. Cliente", f8, Brushes.Black, 50, 110);
            e.Graphics.DrawString("Importe total", f8, Brushes.Black, 570, 110, right);
            e.Graphics.DrawString("Cantidad", f8, Brushes.Black, 450, 110, right);
            e.Graphics.DrawString("Fecha", f8, Brushes.Black, 260, 110, right);
            e.Graphics.DrawString("Hora", f8, Brushes.Black, 350, 110, right);
            e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120);

            int height = 0;
            int height2 = 145 + height;
            int startY = 145;
            int startX = 0;
            int lineHeight = 22;
            decimal totalImporte = 0;

            int selectedMonth = comboBoxMes.SelectedIndex + 1;
            int selectedDay = comboBoxDia.SelectedIndex + 1;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (DateTime.TryParse(row.Cells["fecha"].Value.ToString(), out DateTime fecha))

                    {
                        bool printRow = true;

                        // Filtrar por mes
                        if (selectedMonth > 0 && fecha.Month != selectedMonth)
                        {
                            printRow = false;
                        }

                        // Filtrar por día
                        if (selectedDay > 0 && fecha.Day != selectedDay)
                        {
                            printRow = false;
                        }

                        if (printRow)
                        {
                            string idVenta = InsertLineBreaks(row.Cells["id_Venta"].Value.ToString(), 13);
                            string nombreCliente = InsertLineBreaks(row.Cells["nombre_cliente"].Value.ToString(), 13);
                            string importeTotalStr = InsertLineBreaks(row.Cells["importeTotal"].Value.ToString(), 13);
                            string cantidad = InsertLineBreaks(row.Cells["cantidad"].Value.ToString(), 13);
                            string fechaStr = InsertLineBreaks(fecha.ToShortDateString(), 13);
                            string hora = InsertLineBreaks(row.Cells["hora"].Value.ToString(), 13);

                            int extraHeight = CalculateLineBreakHeight(nombreCliente, 13, lineHeight);

                            e.Graphics.DrawString(idVenta, f8, Brushes.Black, startX + 4, startY + height + 10);
                            e.Graphics.DrawString(nombreCliente, f8, Brushes.Black, startX + 50, startY + height + 10);
                            e.Graphics.DrawString(importeTotalStr, f8, Brushes.Black, startX + 540, startY + height + 10, right);
                            e.Graphics.DrawString(cantidad, f8, Brushes.Black, startX + 420, startY + height + 10, right);
                            e.Graphics.DrawString(fechaStr, f8, Brushes.Black, startX + 280, startY + height + 10, right);
                            e.Graphics.DrawString(hora, f8, Brushes.Black, startX + 360, startY + height + 10, right);

                            if (decimal.TryParse(row.Cells["importeTotal"].Value.ToString(), out decimal importeTotal))
                            {
                                totalImporte += importeTotal;
                            }

                            height += extraHeight + lineHeight; // Ajustar la altura para la siguiente fila
                        }
                    }
                }
            }

            e.Graphics.DrawString(line, f14, Brushes.Black, 0, startY + height);

            e.Graphics.DrawString(InsertLineBreaks("Total: ", 11), f10b, Brushes.Black, startX + 470, startY + height + 30, right);
            e.Graphics.DrawString(totalImporte.ToString("C2"), f10b, Brushes.Black, startX + 545, startY + height + 30, right);

        }


        private void Reportes_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'spaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.spaDataSet.Ventas);

            comboBoxMes.Visible = false;
            comboBoxDia.Visible = false;



        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Guardar como PDF";
            saveFileDialog.FileName = "reporte.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                changelongpaper();
                SaveToPdf(saveFileDialog.FileName);
            }

        }

        private void changelongpaper()
        {
            int rowcount = dataGridView1.Rows.Count;
            longpaper = 600 + 300;
        }

        private void slideButton1_Click(object sender, EventArgs e)
        {

            if (slideButton1.IsOn)
            {
                comboBoxDia.Visible = true;
                comboBoxMes.Visible = true;
            }
            else
            {
                comboBoxDia.Visible = false;
                comboBoxMes.Visible = false;
                comboBoxDia.Text = "";
                comboBoxMes.Text = "";
            }
        }


        private void SaveToPdf(string filePath)
        {

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                // Crea un nuevo documento PDF
                PdfWriter writer = new PdfWriter(fs);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Agrega el contenido del informe al documento PDF
                AddContentToPdf(document);

                // Cierra el documento PDF
                document.Close();
            }
        }

        private void AddContentToPdf(Document document)
        {
            PdfFont font8 = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            PdfFont font10 = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            PdfFont font101 = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            PdfFont font10b = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            PdfFont font14 = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);

            string line = "__________________________________________________________________________________________________________________";

            // Agrega el contenido al documento PDF
            document.Add(new Paragraph("ARUMA").SetFont(font10).SetTextAlignment(TextAlignment.CENTER));
            document.Add(new Paragraph("Ignacio Altamirano 7A Col.Ex-Hacienda De Santa Monica,").SetFont(font101).SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Tlanepantla De Baz,Estado De México C.P 54050.").SetFont(font101).SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("REPORTE DE VENTAS").SetFont(font8).SetTextAlignment(TextAlignment.CENTER));

            document.Add(new Paragraph("Fecha: " + DateTime.Now.ToShortDateString() + " - Hora: " + DateTime.Now.ToShortTimeString()).SetFont(font8).SetTextAlignment(TextAlignment.LEFT));

            // Encabezados de la tabla
            Table table = new Table(UnitValue.CreatePercentArray(6)).UseAllAvailableWidth();
            table.AddHeaderCell(new Cell().Add(new Paragraph("Id").SetFont(font8)));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Nom. Cliente").SetFont(font8)));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Importe total").SetFont(font8)));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Cantidad").SetFont(font8)));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Fecha").SetFont(font8)));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Hora").SetFont(font8)));

            int selectedMonth = comboBoxMes.SelectedIndex + 1;
            int selectedDay = comboBoxDia.SelectedIndex + 1;

            decimal totalImporte = 0; // Variable para almacenar el importe total

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (DateTime.TryParse(row.Cells["fecha"].Value.ToString(), out DateTime fecha))
                    {
                        bool printRow = true;

                        // Filtrar por mes
                        if (selectedMonth > 0 && fecha.Month != selectedMonth)
                        {
                            printRow = false;
                        }

                        // Filtrar por día
                        if (selectedDay > 0 && fecha.Day != selectedDay)
                        {
                            printRow = false;
                        }

                        if (printRow)
                        {
                            string idVenta = InsertLineBreaks(row.Cells["id_Venta"].Value.ToString(), 13);
                            string nombreCliente = InsertLineBreaks(row.Cells["nombre_cliente"].Value.ToString(), 13);
                            string precioStr = row.Cells["importeTotal"].Value.ToString(); // Obtener el precio desde el DataGridView
                            string cantidad = InsertLineBreaks(row.Cells["cantidad"].Value.ToString(), 13);
                            string fechaStr = InsertLineBreaks(fecha.ToShortDateString(), 13);
                            string hora = InsertLineBreaks(row.Cells["hora"].Value.ToString(), 13);

                            // Calcular el importe total (cantidad * precio)
                            decimal total = 0;
                            if (decimal.TryParse(precioStr, out total))
                            {
                                decimal importeTotal = decimal.Parse(precioStr);
                                totalImporte += importeTotal;

                                // Agregar celdas a la tabla
                                table.AddCell(new Cell().Add(new Paragraph(idVenta).SetFont(font8)));
                                table.AddCell(new Cell().Add(new Paragraph(nombreCliente).SetFont(font8)));
                                table.AddCell(new Cell().Add(new Paragraph(importeTotal.ToString()).SetFont(font8))); // Agregar importe total
                                table.AddCell(new Cell().Add(new Paragraph(cantidad).SetFont(font8)));
                                table.AddCell(new Cell().Add(new Paragraph(fechaStr).SetFont(font8)));
                                table.AddCell(new Cell().Add(new Paragraph(hora).SetFont(font8)));
                            }
                        }
                    }
                }
            }

            // Agregar la tabla al documento
            document.Add(table);

           

            // Agregar total
            document.Add(new Paragraph("Total: " + totalImporte.ToString("C2")).SetFont(font10b).SetTextAlignment(TextAlignment.RIGHT));
        }



    }
}
            
       