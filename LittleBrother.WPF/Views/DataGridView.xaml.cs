using LittleBrother.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace LittleBrother.WPF.Views
{
    /// <summary>
    /// Logika interakcji dla klasy DataGridView.xaml
    /// </summary>
    public partial class DataGridView : UserControl
    {
        public DataGridView()
        {
            InitializeComponent();

            var vm = new MusicViewModel();

            vm.Infos.Add(new MusicInfoViewModel {Title = "Hans" });
            vm.Infos.Add(new MusicInfoViewModel { Title = "DasXX" });
            vm.Infos.Add(new MusicInfoViewModel { Title = "VVDD" });

            DataContext = vm;

            Loaded += DataGridView_Loaded;
           
        }

        public void UnselectAll()
        {
            Jordan.UnselectAll();
        }

        private void DataGridView_Loaded(object sender, RoutedEventArgs e)
        {
            var k = Jordan;

           
        }

    }
}
