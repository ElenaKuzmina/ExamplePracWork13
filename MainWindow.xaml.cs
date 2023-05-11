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

            //список объектов класса ClassLibrary

            //List<ClassLibrary> libraries = new List<ClassLibrary>();

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
    }
}
