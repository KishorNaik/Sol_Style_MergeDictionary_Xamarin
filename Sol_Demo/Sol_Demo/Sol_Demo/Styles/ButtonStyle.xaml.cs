using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sol_Demo.Styles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonStyle : ResourceDictionary // Remove Content Page Class and Add Resource Dictionary class
    {
        public ButtonStyle()
        {
            InitializeComponent();
        }
    }
}