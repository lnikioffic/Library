using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.tools
{
    internal static class Extensions
    {
        public static void SetDataToComboBox<T>(this ComboBox comboBox, List<T> data)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.DataSource = data;
            comboBox.SelectedItem = null;
        }

        public static void SetDataToComoboBoxEdite<T>(this ComboBox comboBox, List<T> data, T selected)
        {
            comboBox.DataSource = data;
            foreach (var item in data)
            {
                if (item.ToString() == selected.ToString())
                {
                    comboBox.SelectedItem = item;
                    break;
                }

            }
        }

        public static void SetDataNull(this ComboBox comboBox)
        {
            comboBox.DataSource = null;
        }
    }
}
