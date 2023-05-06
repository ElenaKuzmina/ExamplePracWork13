using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePracWork13.Classes
{
    internal class ClassLibrary
    {
        // Предметная область: Библиотека.Минимальный список характеристик: 
        //	номер читательского билета, 
        //	ФИО читателя,
        //	адрес,
        //	телефон, 
        //	название книги,
        //	дата выдачи книги читателю,
        //	дата сдачи книги читателем.

        //поля класса
        string numberReaderBillet;
        string fullname;
        string adress;
        string phone;
        string titleBook;
        DateTime dateIssue;
        DateTime dateReturn;

        //свойства для доступа к полям
       public string NumberReaderBillet
        { get { return numberReaderBillet;} set { numberReaderBillet = value; } }
        public string FullName
        { get { return fullname; } set { fullname = value; } }
        public string Adress
        { get { return adress; }  set { adress = value; } }
        public string Phone
        { get { return phone; } set { phone = value; } }
        public string TitleBook
        { get { return titleBook; } set { titleBook = value; } }
        public DateTime DateIssue
        { get { return dateIssue; } set { dateIssue = value; } }
        public DateTime DateReturn
        { get { return dateReturn; } set { dateReturn = value; } }

        //конструкторы
        public ClassLibrary() 
        {
            numberReaderBillet = string.Empty;
            fullname = string.Empty;
            adress = string.Empty;
            phone= string.Empty;
            titleBook= string.Empty;
            dateIssue = DateTime.Now; // сегодняшняя дата
            dateReturn = DateTime.Now.AddDays(10); // плюс 10 дней
        }
        public ClassLibrary(string number, string fname, 
            string adr, string ph, string title, 
            DateTime dateIs, DateTime dateRet)
        {
            numberReaderBillet = number;
            fullname = fname;
            adress = adr;
            phone = ph;
            titleBook = title;
            dateIssue = dateIs;
            dateReturn = dateRet;
            
        }
    }
}
