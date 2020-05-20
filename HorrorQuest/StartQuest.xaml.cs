using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HorrorQuest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartQuest : ContentPage
    {
        public StartQuest()
        {
            InitializeComponent();
        }

        private void Quest_Click(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new QuestOne());
        }
    }
}