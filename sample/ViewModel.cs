using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    [ObservableObject]
    internal partial class ViewModel
    {
        [ObservableProperty]
        private int id;

        partial void OnIdChanged(int value)
        {
            throw new NotImplementedException();
        }

        [ObservableProperty]
        private string name;

        partial void OnNameChanged(string value)
        {
            throw new NotImplementedException();
        }
    }
}
