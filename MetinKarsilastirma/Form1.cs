using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Word =Microsoft.Office.Interop.Word;
using System.Net;
using System.Web;
using net.zemberek.erisim;
using net.zemberek.yapi;
using net.zemberek.tr.yapi;
using net.zemberek.bilgi;


namespace MetinKarsilastirma
{
    public partial class Form1 : Form
    {
        Word.ApplicationClass MSdoc;
        object path;
        object Unknown = Type.Missing;
        List<KelimeModelGrid> kelimelist2;
        List<KelimeModelGrid> kelimelist1;
        int durum = 0;
        string Metin = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyabir_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = " Pdf Dosyası |*.pdf| Txt Dosyası|*.txt| Word Dosyası|*.doc| Word  Dosyası (docx)|*.docx";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.ShowDialog();

                // Burası Dosyarı içerli alır.

                if (openFileDialog1.FilterIndex == 1)
                {
                    Metin = ReadPdfFile(openFileDialog1.FileName);
                    ReadMetinGrid1(Metin);
                }
                else if (openFileDialog1.FilterIndex == 2)
                {
                    Metin = FileTools.ReadFileString(openFileDialog1.FileName);
                    ReadMetinGrid1(Metin);
                    durum += 1;
                    if (durum == 2)
                    {
                        btnkarsilastir.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Metin Hatalı veya Görsel öğe çok ");
            }




        }

        public void ReadMetinGrid1(string value1)
        {
            kelimelist1 = new List<KelimeModelGrid>();
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            // dosyayı okuduk.
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            //byte[] b = p.get(2); //Hangi sayfasını texte dökecek

            string[] Kelimeler = value1.Split(delimiterChars);
            //Kelim
            List<KelimeModel> _model = new List<KelimeModel>();
            foreach (var item in Kelimeler)
            {
                string key = item.Trim();

                if (!string.IsNullOrEmpty(key) && key.Length > 1)
                {
                    KelimeModel kelime = new KelimeModel();
                    kelime.Kelime = key;
                    _model.Add(kelime);
                }
            }

            int count = CountWordsModified(value1);
            lblkelimecount.Text = " " + count;
            int tekrar = _model.GroupBy(x => x.Kelime).Count(x => x.Count() > 1);
            //  string[] essizIsımDizisi = count.Distinct().ToArray();
            var pl = from r in _model
                     orderby r.Kelime
                     group r by r.Kelime into grp
                     select new { key = grp.Key, cnt = grp.Count() };

            foreach (var item in pl)
            {
                KelimeModelGrid grid = new KelimeModelGrid();
                if (item.cnt > 1)
                {
                    grid.Sayi = item.cnt;
                    grid.Kelime = item.key;
                    grid.Sayi = item.cnt;
                    kelimelist1.Add(grid);
                }
            }
            label3.Text = " " + tekrar;
            dataGridView1.CurrentCell = null;
            dataGridView1.DataSource = kelimelist1.OrderByDescending(t => t.Sayi).ToList();
        }
        public void ReadMetinGrid2(string value1)
        {
            kelimelist2 = new List<KelimeModelGrid>();
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            // dosyayı okuduk.
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            //byte[] b = p.get(2); //Hangi sayfasını texte dökecek

            string[] Kelimeler = value1.Split(delimiterChars);
            //Kelim
            List<KelimeModel> _model = new List<KelimeModel>();
            foreach (var item in Kelimeler)
            {
                string key = item.Trim();

                if (!string.IsNullOrEmpty(key) && key.Length > 1)
                {
                    KelimeModel kelime = new KelimeModel();
                    kelime.Kelime = key;
                    _model.Add(kelime);
                }
            }

            int count = CountWordsModified(value1);
            lbl2nolukelimesayisi.Text = " " + count;
            int tekrar = _model.GroupBy(x => x.Kelime).Count(x => x.Count() > 1);
            //  string[] essizIsımDizisi = count.Distinct().ToArray();
            var pl = from r in _model
                     orderby r.Kelime
                     group r by r.Kelime into grp
                     select new { key = grp.Key, cnt = grp.Count() };

            foreach (var item in pl)
            {
                KelimeModelGrid grid = new KelimeModelGrid();
                if (item.cnt > 1)
                {
                    grid.Sayi = item.cnt;
                    grid.Kelime = item.key;

                    kelimelist2.Add(grid);
                }
            }
            lbl2tekerar.Text = " " + tekrar;
            dataGridView2.CurrentCell = null;
            dataGridView2.DataSource = kelimelist2.OrderByDescending(t => t.Sayi).ToList();
        }
        public int CountWordsModified(string s)
        {
            return Regex.Matches(s, @"[A-Za-z0-9]+").Count;
        }

        public string ReadPdfFile(string fileName)
        {
            StringBuilder text = new StringBuilder();

            if (File.Exists(fileName))
            {
                PdfReader pdfReader = new PdfReader(fileName);

                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                    text.Append(currentText);
                }
                pdfReader.Close();
            }
            return text.ToString();
        }
        public static class FileTools
        {
            public static string ReadFileString(string path)
            {
                // Use StreamReader to consume the entire text file.
                using (StreamReader reader = new StreamReader(path))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnkarsilastir.Enabled = false;
        }

        private void btn2dosya_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = " Pdf Dosyası |*.pdf| Txt Dosyası|*.txt| Word Dosyası|*.doc| Word  Dosyası (docx)|*.docx";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.ShowDialog();

                // Burası Dosyarı içerli alır.

                if (openFileDialog1.FilterIndex == 1)
                {
                    Metin = ReadPdfFile(openFileDialog1.FileName);
                    ReadMetinGrid2(Metin);
                    btnkarsilastir.Enabled = true;
                }
                else if (openFileDialog1.FilterIndex == 2)
                {
                    Metin = FileTools.ReadFileString(openFileDialog1.FileName);
                    ReadMetinGrid2(Metin);
                    btnkarsilastir.Enabled = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Metin Hatalı veya Görsel öğe çok ");
            }
        }

        private void klasörAÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnkarsilastir_Click(object sender, EventArgs e)
        {

            int benzerlik = 0;
            foreach (var List1 in kelimelist1)
            {
                foreach (var List2 in kelimelist2)
                {
                    if (List1.Kelime == List2.Kelime)
                    {
                        benzerlik++;
                    }
                }
            }
            lblbenzerSayi.Text = " " + benzerlik;


        }

        public double Hesapla(int filebircount, int file2count, int bezercount)
        {

            double oran = file2count;
            return oran;
        }
        private void word2PDF(object Source, object Target)
        {   //Creating the instance of Word Application
            if (MSdoc == null) MSdoc = new Microsoft.Office.Interop.Word.ApplicationClass();

            try
            {
                MSdoc.Visible = false;
                MSdoc.Documents.Open(ref Source, ref Unknown,
                     ref Unknown, ref Unknown, ref Unknown,
                     ref Unknown, ref Unknown, ref Unknown,
                     ref Unknown, ref Unknown, ref Unknown,
                     ref Unknown, ref Unknown, ref Unknown, ref Unknown, ref Unknown);
                MSdoc.Application.Visible = false;
                MSdoc.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateMinimize;

                object format = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF;

                MSdoc.ActiveDocument.SaveAs(ref Target, ref format,
                        ref Unknown, ref Unknown, ref Unknown,
                        ref Unknown, ref Unknown, ref Unknown,
                        ref Unknown, ref Unknown, ref Unknown,
                        ref Unknown, ref Unknown, ref Unknown,
                       ref Unknown, ref Unknown);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (MSdoc != null)
                {
                    MSdoc.Documents.Close(ref Unknown, ref Unknown, ref Unknown);
                    //WordDoc.Application.Quit(ref Unknown, ref Unknown, ref Unknown);
                }
                // for closing the application
                MSdoc.Quit(ref Unknown, ref Unknown, ref Unknown);
            }
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Word document|*.doc |Word document|*.docx";
            saveFileDialog1.Title = "Save the Word Document";
            saveFileDialog1.ShowDialog();
          
            Word.Application app = new Word.Application();
            Word.Document doc;
            object missing = Type.Missing;
            object readOnly = true;
            try
            {

                
               
            }
            catch (Exception)
            {

                throw;
            }




        }


        public class KelimeModel
        {

            public string Kelime { get; set; }
        }

        public class KelimeModelGrid
        {

            public string Kelime { get; set; }
            public int Sayi { get; set; }
            public string EslemeStatus { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Zemberek sem = new Zemberek(new TurkiyeTurkcesi());
            
            //var zemberek = new Zemberek(new TurkiyeTurkcesi());
            //var suggestions = zemberek.oner(Metin);
            
        }
    }
}
