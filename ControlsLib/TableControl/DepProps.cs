using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlsLib
{
    public partial class TableControl : UserControl
    {
        /*  
        Видимое на виде количество строк таблицы. Зависит от велчины по высоте 
        отображаемой области таблицы. Будет равно частному от деления высоты
        видимой области таблицы на заданную высоту строки +1. В случае, когда
        все строки полностью попадают в видимую область
        VisibleRowsNumber будет равно RowsNumber
        */
        public static readonly DependencyProperty VisibleRowsNumberProperty;
        public int VisibleRowsNumber
        {
            get { return (int)GetValue(VisibleRowsNumberProperty); }
            private set { SetValue(VisibleRowsNumberProperty, value); }
        }

        /*
        Количество строк в таблице. Должно соответствовать количеству элементов
        В случае, когда все строки полностью попадают в видимую область
        RowsNumber будет равно VisibleRowsNumber
        */
        public static readonly DependencyProperty RowsNumberProperty;
        public int RowsNumber
        {
            get { return (int)GetValue(RowsNumberProperty); }
            set { SetValue(RowsNumberProperty, value); }
        }
    }
}
