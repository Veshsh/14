using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace _14Budget_accounting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DateTime date = DateTime.Now;
        private List<int> now = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            Ster.data =(Ster.dester<List<Data>>(Ster.Sterfile)==null)? new List<Data>() : Ster.dester<List<Data>>(Ster.Sterfile);
            Ster.type = (Ster.dester<HashSet<string>>(Ster.SterfileType) == null) ? new HashSet<string>() : Ster.dester<HashSet<string>>(Ster.SterfileType);
            Picin.Text = date.ToShortDateString();
            Summ();
            gridUpdate();
            TypeList.ItemsSource = Ster.type;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 w= new Window1();
            if(w.ShowDialog()==true )
                Ster.type.Add(Window1.newtype);
            w.Close();
            TypeList.ItemsSource = Ster.type;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ster.data.Add(new Data(date, null,0,true,null));
            gridUpdate();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Grid.SelectedIndex != -1)
            {
                Ster.data.RemoveAt(now[Grid.SelectedIndex]);
                now.RemoveAt(Grid.SelectedIndex);
            }
            gridUpdate();
        }
        private void Grid_SelectionChanged(object sender, DataGridCellEditEndingEventArgs e)
        {
            Summ();
            if (Grid.SelectedIndex != -1)
                Ster.data[now[Grid.SelectedIndex]] = (Data)Grid.SelectedValue;

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Ster.ster(Ster.data, Ster.Sterfile);
            Ster.ster(Ster.type, Ster.SterfileType);
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Ster.ster(Ster.data, Ster.Sterfile);
            Ster.ster(Ster.type, Ster.SterfileType);
        }
        private void gridUpdate()
        {
            now = new List<int>();
            date = Convert.ToDateTime(Picin.Text);
            for (int i = 0; i < Ster.data.Count; i++)
                if (Ster.data[i].Date.ToShortDateString() == date.ToShortDateString())
                    now.Add(i);

            Grid.ItemsSource = null;
            List<Data> items = new List<Data>();
            foreach (int i in now)
                items.Add(Ster.data[i]);
            Grid.ItemsSource = items;
        }
        private void DataPic(object sender, SelectionChangedEventArgs e)
        {
            gridUpdate();
        }
        private void Summ()
        {
            int summ = 0;
            foreach (Data i in Ster.data)
                summ += (i.Pluss) ? (int)i.Mony : (int)i.Mony * -1;
            Cost.Text = "Итог:" +summ.ToString();
        }
    }
}
