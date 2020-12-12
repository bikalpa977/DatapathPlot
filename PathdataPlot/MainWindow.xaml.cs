using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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
using DataPath = System.Windows.Shapes.Path;


namespace PathdataPlot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        string MyFilePath = "C:\\Users\\Bikalpa\\Documents\\testdll\\pathdata.json";
        public MainWindow()
        {
            InitializeComponent();


            JArray data = JArray.Parse(File.ReadAllText(MyFilePath));


            DataPath dpath;
        
            for (int i = 0; i < data.Count; i++)
            {

                

                dpath = new DataPath();
                dpath.Stroke = Brushes.Black;
                dpath.StrokeThickness = 0.5;
                Geometry g = Geometry.Parse(data[i].ToString());

               
                
                


                dpath.Data = g;
                Mycanvas.Children.Add(dpath);

            }

            Console.WriteLine(data[0]);
           
           


        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
