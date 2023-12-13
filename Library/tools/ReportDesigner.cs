using Library.Models;
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

        public string Title { get; }

        private Document doc;

        private Word.Application WordApp;

        public ReportDesigner(string title, DateTime dateCreate)
        {
            Title = title;
            var date = DateTime.Now.ToString("dd.MM.yyyy-HH.mm");
            path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) 
                + $@"/Отчёт {title}_{dateCreate.ToString("dd.MM.yyyy-HH.mm")}.docx";


            WordApp = new Word.Application();
            WordApp.Visible = true;
            doc = WordApp.Documents.Add();
        }

        public void Save()
        {
            doc.SaveAs2(path);
            doc.Close();
            WordApp.Quit();
        }

        public void AddHeader()
        {
            // Добавляем заголовок
            Paragraph header = doc.Paragraphs.Add();
            header.Range.Text = $"Отчёт \"{Title}\"" ;
            Setting(header.Range);
            header.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; // Выравнивание по центру
            header.Range.InsertParagraphAfter();
            
        }

        public void AddDate(string dateStar, string dateEnd)
        {
            Paragraph date = doc.Paragraphs.Add();
            date.Range.Text = $"Период {dateStar} - {dateEnd}";
            date.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            date.Range.InsertParagraphAfter();
        }
        
        public void AddSignature(Staff info)
        {
            string staffName = "";
            if (info.Patronymic != "")
                staffName = $"{info.LastName} {info.FirstName.Substring(0, 1)}. {info.Patronymic?.Substring(0, 1)}";
            else
                staffName = $"{info.LastName} {info.FirstName.Substring(0, 1)}.";
            Paragraph listItem = doc.Paragraphs.Add();
            listItem.Range.Text = $"{info.Role} _________ / {staffName}";
            listItem.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight; 
            listItem.Range.InsertParagraphAfter();
        }

        public void AddSignatureDate(DateTime info)
        {
            Paragraph listItem = doc.Paragraphs.Add();
            listItem.Range.Text = $"{info.ToString("dd.MM.yyyy")}";
            listItem.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            listItem.Range.InsertParagraphAfter();
        }

        public void AddList(string[] items)
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

        public void CreateTable(int numRows, int numColumns)
        {
            // Добавляем таблицу
            Table table = doc.Tables.Add(GetTableRange(doc), numRows, numColumns);

            // Пример форматирования таблицы
            FormatTable(table);
        }

        public void CreateTableWithContent(List<List<string>> content)
        {
            int numRows = content.Count;
            int numColumns = content[0].Count;
            
            // Добавляем таблицу
            Table table = doc.Tables.Add(GetTableRange(doc), numRows, numColumns);

            // Заполняем таблицу содержимым
            FillTableContent(table, content);

            // Пример форматирования таблицы
            FormatTable(table);
        }

        public void Setting(Word.Range range)
        {
            range.Font.Size = 14;
            range.Font.Name = "Times New Roman";
            range.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly;
            range.ParagraphFormat.LineSpacing = 18;
        }

        private void FormatTable(Table table)
        {
            // Пример форматирования таблицы
            table.Borders.Enable = 1; // Включаем границы
            table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitContent); // Автоматическая подгонка размера
            table.Rows.Alignment = WdRowAlignment.wdAlignRowCenter; // Выравнивание по центру
        }

        private Word.Range GetTableRange(Document doc)
        {
            // Возвращает Range для добавления таблицы в конец документа
            return doc.Range(doc.Content.End - 1, doc.Content.End - 1);
        }

        private void FillTableContent(Table table, List<List<string>> content)
        {
            for (int row = 1; row < table.Rows.Count + 1; row++)
            {
                for (int col = 1; col < table.Columns.Count + 1; col++)
                    table.Cell(row, col).Range.Text = content[row - 1][col - 1].ToString();
            }
        }

    }
}
