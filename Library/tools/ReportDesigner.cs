using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Library.tools
{
    public class ReportDesigner
    {
        private string path;

        public ReportDesigner(string t)
        {
            var date = DateTime.Now.ToString("dd.MM.yyyy-HH.mm");
            path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) 
                + $@"/test {date}.docx";

            var WordApp = new Word.Application();
            WordApp.Visible = true;
            var doc = WordApp.Documents.Add();
            string[] a = t.Split("\n");

            AddHeader(doc, "Мой Заголовок");
            AddList(doc, a);

            doc.SaveAs2(path);
            doc.Close();
            WordApp.Quit();
        }

        public void AddHeader(Document doc, string headerText)
        {
            // Добавляем заголовок
            Paragraph header = doc.Paragraphs.Add();
            header.Range.Text = headerText;
            Setting(header.Range.Font);
            header.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; // Выравнивание по центру
            header.Range.InsertParagraphAfter();
            
        }

        public void AddList(Document doc, string[] items)
        {
            // Добавляем список
            foreach (var item in items)
            {
                Paragraph listItem = doc.Paragraphs.Add();
                listItem.Range.Text = $"• {item}"; // Знак "•" для маркированного списка
                listItem.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft; // Выравнивание по левому краю
                listItem.Range.InsertParagraphAfter();
            }
        }

        public void Setting(Word.Font font)
        {
            font.Size = 14;
            font.Name = "Times New Roman";
        }
    }
}
