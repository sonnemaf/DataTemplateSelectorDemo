using DataTemplateSelectorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DataTemplateSelectorDemo.Helpers {
    class EmployeeDataTemplateSelector : DataTemplateSelector {

        public DataTemplate EvenTemplate { get; set; }
        public DataTemplate OddTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) {
            if (item is Employee emp) {
                return emp.Salary % 2 == 0 ? EvenTemplate : OddTemplate; 
            }
            return base.SelectTemplateCore(item, container);
        }
    }
}
