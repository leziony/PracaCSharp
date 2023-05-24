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
using ToDoList3.ToDo2;

namespace ToDoList3
{
    /// <summary>
    /// Logika interakcji dla klasy WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
            date_input.SelectedDate = null; //nulljuemy selekcje bazy by nie dopuścić do sytuacji by nie można byłoby wpisać terminu.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new TodoContext())
            {
                context.Database.EnsureCreated(); // W każdym kroku gdzie jest wymagana baza danych sprawdzamy czy jest. Jeśli nie, tworzymy ją z danych zawartych w ToDoContext.cs
                if (name_input.Text.Length == 0 || date_input.SelectedDate == null) //Jeżeli czegoś nie wpisaliśmy, dostaniemy błąd.
                {
                    System.Windows.MessageBox.Show("Należy wypełnić wszystkie zmienne", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                var newlisting = new Lister
                {
                    Name = name_input.Text,
                    Deadline = (DateTime)date_input.SelectedDate
                };
                context.Listers.Add(newlisting); //Add działa jako INSERT statement.
                context.SaveChanges();
            }
            System.Windows.MessageBox.Show("Operacja dodania zakonczona suckesem!", "Suckes!", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}
