using ExamplePracWork13.Classes;
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
using System.Windows.Shapes;

namespace ExamplePracWork13
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
            TxbDateIssue.Text = DateTime.Now.ToString();
            TxbDateReturn.Text = DateTime.Now.AddDays(10).ToString();
        }

        private void BtnAddReader_Click(object sender, RoutedEventArgs e)
        {
            ClassLibrary library = new ClassLibrary()
            {
                NumberReaderBillet = TxbBookReader.Text,
                FullName = TxbFullName.Text,
                Adress = TxbAdress.Text,
                Phone = TxbPhone.Text,
                TitleBook = TxbBookTitle.Text,
                DateIssue = Convert.ToDateTime(TxbDateIssue.Text),
                DateReturn = Convert.ToDateTime(TxbDateReturn.Text)

            };
            ClassHelp.libraries.Add(library);
        }
    }
}
