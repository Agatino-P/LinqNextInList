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

namespace LinqNexInList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
		{
			List<string> fruits = new List<string> { "apple", "banana", "orange", "raspberry", "kiwi" };
			string NextOf = "orange";
			string NextOfIs;

			NextOfIs = fruits.SkipWhile(x => x != NextOf).Skip(1).DefaultIfEmpty(fruits[0]).FirstOrDefault();

			NextOf = "kiwi";
			NextOfIs = fruits.SkipWhile(x => x != NextOf).Skip(1).FirstOrDefault();

			var endoflist = fruits.SkipWhile(x => x != NextOf).Skip(1).FirstOrDefault();

			NextOf = "kiwi";
			NextOfIs = fruits.SkipWhile(x => x != NextOf).Skip(1).DefaultIfEmpty(fruits[0]).FirstOrDefault();
			

			string PrevOf = "orange";
			string PrevOfIs;

			PrevOfIs = fruits.TakeWhile(x => x != PrevOf).DefaultIfEmpty(fruits[fruits.Count - 1]).LastOrDefault();
			

			PrevOf = "apple";
			PrevOfIs = fruits.TakeWhile(x => x != PrevOf).LastOrDefault();
			

		}
	}
}
