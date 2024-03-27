using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

using HelixToolkit.Wpf;

namespace WpfHelixToolkit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Gyongyok> gyongyok = new();

            foreach (string sor in File.ReadAllLines("gyongyok.txt").Skip(1))
            {
                gyongyok.Add(new Gyongyok(sor));
            }
            
            foreach (Gyongyok aktBogyo in gyongyok)
            {
                EllipsoidVisual3D ellipsoid = new EllipsoidVisual3D();
                ellipsoid.Center = new Point3D(aktBogyo.X, aktBogyo.Y, aktBogyo.Z);
                ellipsoid.Fill = new SolidColorBrush(Colors.LightGreen);
                ter.Children.Add(ellipsoid);
            }
        }
    }
}