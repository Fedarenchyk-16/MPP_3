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

namespace AssemblyBrowser //ASSEMBLY - сборка
{
    public partial class TreeViewPage : Page
    {
        public TreeViewPage()
        {
            InitializeComponent();
            var assemblyVM = new AssemblyViewModel();
            DataContext = assemblyVM;
            assemblyTree.ItemsSource = assemblyVM.AssembliesInfo;
        }
    }
}
