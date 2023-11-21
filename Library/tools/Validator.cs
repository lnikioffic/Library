using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.tools
{
    public static class Validator
    {
        public static bool ValidateTextBox(Dictionary<TextBox, Label> errorLables)
        {
            List<Label> missingFilds = new List<Label>();
            foreach(var item in errorLables)
            {
                if (item.Key.Text == "" || string.IsNullOrWhiteSpace(item.Key.Text))
                    missingFilds.Add(item.Value);
            }
            foreach(var item in missingFilds)
            {
                item.Text = "Заполните поле";
            }
            //foreach(var control in controls.Controls)
            //{
            //    if(control is TextBox textBox && (textBox.Text == ""))
            //        missingFilds.Add(textBox);
            //}
            //foreach (var control in errorLables.Keys)
            //{
            //    errorLables[control].Text = string.Empty;
            //}
            if (missingFilds.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static bool ValidateComboBox(Dictionary<ComboBox, Label> errorLables)
        {
            List<Label> missingFilds = new List<Label>();
            foreach (var item in errorLables)
            {
                if (item.Key.SelectedItem == null)
                    missingFilds.Add(item.Value);
            }
            foreach (var item in missingFilds)
            {
                item.Text = "Заполните поле";
            }
            if (missingFilds.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static bool ValidateData(Dictionary<DataGridView, Label> errorLables)
        {
            List<Label> missingFilds = new List<Label>();
            foreach (var item in errorLables)
            {
                if (item.Key.DataSource == null || item.Key.Rows.Count == 0)
                    missingFilds.Add(item.Value);
            }
            foreach (var item in missingFilds)
            {
                item.Text = "Заполните поле";
            }
            if (missingFilds.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static bool ValidateDate(Dictionary<DateTimePicker, Label> lab)
        {
            List<Label> missingFilds = new List<Label>();
            foreach (var item in missingFilds)
            {
                item.Text = "Заполните поле";
            }
            if (missingFilds.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
