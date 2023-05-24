using Google.Protobuf.WellKnownTypes;
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
    /// Logika interakcji dla klasy WindowDelete.xaml
    /// </summary>
    public partial class WindowDelete : Window
    {
        public WindowDelete()
        {
            InitializeComponent();
        }

        private void ID_input_PreviewTextInput(object sender, TextCompositionEventArgs e) //ID powinno obsługiwać jedynie cyfry.
        {
            e.Handled = IsTextNumeric(e.Text);
        }
        private static bool IsTextNumeric(string str) //Regex poszukujący tego. 
        {
            System.Text.RegularExpressions.Regex reg = new("[^0-9]");
            return reg.IsMatch(str);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new TodoContext())
            {
                context.Database.EnsureCreated(); // W każdym kroku gdzie jest wymagana baza danych sprawdzamy czy jest. Jeśli nie, tworzymy ją z danych zawartych w ToDoContext.cs
                if (String.IsNullOrEmpty(ID_input.Text)) //Jeśli ID nie jest wpisane, podaj ID.
                {
                    System.Windows.MessageBox.Show("Podaj ID!", "Błąd!",MessageBoxButton.OK,MessageBoxImage.Error);
                    return;
                }
                int value = int.Parse(ID_input.Text);
                var edited_listing = context.Listers.FirstOrDefault(b => b.ID.Equals(value)); //oczekujemy 1 zadania o tym samym ID
                if (edited_listing == null) //Jeśli nie ma, to nie ma co usunąć.
                {
                    System.Windows.MessageBox.Show("Nie istnieje zadanie pod tym ID!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    Close();
                    return;
                }
                context.Listers.Remove(edited_listing); //Remove działa jako DELETE statement.
                context.SaveChanges();
            }
            System.Windows.MessageBox.Show("Dane zostały usunięte!", "Suckes!", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}
