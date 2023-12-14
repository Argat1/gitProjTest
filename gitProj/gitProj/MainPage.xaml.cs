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
            

            /*BNIResult p = new BNIResult(4,"dziala4",DateTime.Now,180,50,"git");
            BNIResult p1 = new BNIResult(5, "dziala5", DateTime.Now, 180, 50, "git");


            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BNIResult4.json");

            

            List<BNIResult> list = new List<BNIResult>();

            

            list.Add(p);
            list.Add(p1);

            string d = JsonConvert.SerializeObject(list);
            File.WriteAllText(path, d);*/
            Load();
        }
        private void Load()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BNIResult4.json");

            if (File.Exists(path))
            {
                var file = File.ReadAllText(path);
                List<BNIResult> list = JsonConvert.DeserializeObject<List<BNIResult>>(file);

                listView.ItemsSource = list;
            }
        }

    }
}
