using Microsoft.VisualBasic;
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
    /// Logika interakcji dla klasy WindowEdit.xaml
    /// </summary>
    public partial class WindowEdit : Window
    {
        public WindowEdit()
        {
            InitializeComponent();
            date_input.SelectedDate = null;
        }

        private void ID_input_PreviewTextInput(object sender, TextCompositionEventArgs e) //ID powinno obsługiwać jedynie cyfry.
        {
            e.Handled = IsTextNumeric(e.Text);
        }
        private static bool IsTextNumeric(string str) //Regex poszukujący tego
        {
            System.Text.RegularExpressions.Regex reg = new("[^0-9]");
            return reg.IsMatch(str);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new TodoContext())
            {
                context.Database.EnsureCreated(); // W każdym kroku gdzie jest wymagana baza danych sprawdzamy czy jest. Jeśli nie, tworzymy ją z danych zawartych w ToDoContext.cs
                if (String.IsNullOrEmpty(ID_input.Text)) //Jeśli nie ma ID, to jest to błąd.
                {
                    System.Windows.MessageBox.Show("Podaj ID!","Błąd!",MessageBoxButton.OK,MessageBoxImage.Warning);
                    return;
                }
                int value = int.Parse(ID_input.Text);
                var edited_listing = context.Listers.FirstOrDefault(b => b.ID.Equals(value));
                if (edited_listing == null)
                {
                    System.Windows.MessageBox.Show("Nie istnieje zadanie pod tym ID!", "Błąd!",MessageBoxButton.OK,MessageBoxImage.Error);
                    return;
                }
                    if (name_input2.Text.Length != 0){
                    edited_listing.Name = name_input2.Text; //Modyfikujemy text tylko gdy do podaliśmy.
                    }
                    if (date_input.SelectedDate != null) {
                        edited_listing.Deadline = (DateTime)date_input.SelectedDate; //Modyfikujemy date tylko jeśli została podana.
                    }
                    if(!context.ChangeTracker.HasChanges()) //Brak zmian? Brak wykonania czynności!
                    {
                    System.Windows.MessageBox.Show("Brak zmian do zapisania", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    Close();
                    return;
                }
                context.SaveChanges();
            }
            System.Windows.MessageBox.Show("Edycja zakonczona suckesem!", "Suckes!",MessageBoxButton.OK,MessageBoxImage.Information);
            Close();
        }
    }
}
