using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleBrother.WPF.ViewModels
{
    public class MusicViewModel
    {
        public ObservableCollection<MusicInfoViewModel> Infos { get; set; }

        public MusicViewModel()
        {
            Infos = new ObservableCollection<MusicInfoViewModel>();
        }
    }
}
