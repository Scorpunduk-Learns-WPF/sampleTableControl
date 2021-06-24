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
        static TableControl()
        {
            VisibleRowsNumberProperty =
                SetIntegerDependencyProperty(
                    nameof(VisibleRowsNumber),
                    typeof(TableControl),
                    null);

            RowsNumberProperty =
                SetIntegerDependencyProperty(
                    nameof(RowsNumber),
                    typeof(TableControl),
                    null);
        }

        /* Регистрации свойства зависимости типа Int32        
        Для свойств 
        - RowsNumberProperty
        - VisibleRowsNumberProperty
        */
        public static DependencyProperty SetIntegerDependencyProperty
            (
            string propName, 
            Type ownerType, 
            PropertyChangedCallback changedCallback
            )
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.DefaultValue = 0;
            metadata.AffectsMeasure = true;
            metadata.DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            metadata.PropertyChangedCallback += changedCallback;
            metadata.IsNotDataBindable = false;
            metadata.BindsTwoWayByDefault = true;

            return DependencyProperty.Register(propName, typeof(int), ownerType, metadata);
        }
    }
}
