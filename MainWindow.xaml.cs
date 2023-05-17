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
using ExamplePracWork13.Classes;

namespace ExamplePracWork13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CmbFiltr.ItemsSource = ClassHelp.cities;

           //один объект класса ClassLibrary
            ClassLibrary library = new ClassLibrary()
            {
                NumberReaderBillet = "00000001",
                FullName = "Кузьмина Елена Евгеньвна",
                Adress = "Ликино-Дулево",
                Phone = "+7(999)1112233",
                TitleBook= "Самоучитель по C# для чайников",
                DateIssue = DateTime.Now,
                DateReturn= DateTime.Now.AddDays(10)

            };
            ClassHelp.libraries.Add(library);

            //источник данных таблицы - список объектов
            DtgListBooks.ItemsSource = ClassHelp.libraries;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {//переход на форму добавления
            WindowAdd windowAdd = new WindowAdd();
            windowAdd.ShowDialog();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {//поиск по ФИО
            DtgListBooks.ItemsSource = ClassHelp.libraries.Where(x=>x.FullName.Contains(TxtSearch.Text)).ToList();
        }

        
        private void CmbFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //фильтр по городам
            string city = ClassHelp.cities[CmbFiltr.SelectedIndex];
            if (CmbFiltr.SelectedIndex != 0)
                DtgListBooks.ItemsSource = ClassHelp.libraries.Where(x => x.Adress == city).ToList();
            else
                DtgListBooks.ItemsSource = ClassHelp.libraries;
        }

        private void RbUp_Checked(object sender, RoutedEventArgs e)
        {
            DtgListBooks.ItemsSource = ClassHelp.libraries.OrderBy(x => x.FullName).ToList();
        }
    

        private void RbDown_Checked(object sender, RoutedEventArgs e)
        {
            DtgListBooks.ItemsSource = ClassHelp.libraries.OrderByDescending(x => x.FullName).ToList();
        }
    }
}
