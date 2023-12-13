using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace gitProj
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Load();

           
        }
        private void Load()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BNIResult.json");

            if (File.Exists(path))
            {
                var file = File.ReadAllText(path);
                List<BNIResult> list = JsonConvert.DeserializeObject<List<BNIResult>>(file);

                listView.ItemsSource = list;
            }
        }

    }
}
