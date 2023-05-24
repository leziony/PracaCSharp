using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
using ToDoList3.ToDo2;

namespace ToDoList3
{
// Okno głowne programu
    public partial class MainWindow : Window
    {

        public MainWindow()//Inicjalizacja okna
        {
            InitializeComponent();
            date_select.SelectedDate = DateTime.Today;
        }
        public void RefreshDataSet()//Aktualzowanie DataGrid by móc pokazać aktualne wyniki. Aktywowana zawsze gdy jest zmiana.
        {
            using var context = new TodoContext();
            context.Database.EnsureCreated();
            var linker = context.Listers.Where(b => b.Deadline == date_select.SelectedDate).ToList();
            if (date_select.SelectedDate == null)
            {
                linker = context.Listers.ToList();
            }
            Results.ItemsSource = linker;
        }
        public void DeletingPlaceholders() {
            // W momencie pokazywania się kolumn tworzą się duplikaty. Ta metoda usuwa duplikaty.
            Results.Columns.RemoveAt(5);
            Results.Columns.RemoveAt(4);
            Results.Columns.RemoveAt(3);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) //Przy załadowaniu głownego okna za pierwszym razem.
        {
            RefreshDataSet(); //Pierwsze pobranie wraz z usunięciem duplikatów.
            DeletingPlaceholders();
            DateTime tommorow = DateTime.Today;
            tommorow = tommorow.AddDays(1);
            using var context = new TodoContext();
            context.Database.EnsureCreated(); // W każdym kroku gdzie jest wymagana baza danych sprawdzamy czy jest. Jeśli nie, tworzymy ją z danych zawartych w ToDoContext.cs
            var linker = context.Listers.FirstOrDefault(b => b.Deadline == tommorow);
            if (linker != null) //Jeżeli jest jutro zadanie, przy załadowaniu listy dostaniesz komunikat.
            {
                ToastContentBuilder builder = new();
                builder.AddText("Jutro mija termin zadania!");
                builder.AddText("Sprawdz je by nie zapomnieć!");
                builder.AddButton(new ToastButtonDismiss());
                builder.Show();
            }

        }
        private void Window_Closed(object sender, EventArgs e) //Jeżeli główne okno programu zostanie zamknięte, koniec aplikacji.
        {
            Application.Current.Shutdown();
        }
        private void Window_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e) //Ta funkcja aktualizuje dane w tabeli za każdym razem kiedy focus wróci do głownego okna. 
        {
            RefreshDataSet();
            DeletingPlaceholders();
        }
        //Poniższe funkcje przedstawiają funkcje związane z interaktywnimi częściami programu. 
        private void Button_Click_Add(object sender, RoutedEventArgs e) //Pokazanie okna dodania
        {
            WindowAdd add_window = new();
            add_window.Show();
        }
        private void Button_Click_Edit(object sender, RoutedEventArgs e) //Pokazanie okna edycji
        {
            WindowEdit edit_window = new();
            edit_window.Show();
        }
        private void Button_Click_Delete(object sender, RoutedEventArgs e) //Pokazanie okna usunięcia.
        {
            WindowDelete delete_window = new();
            delete_window.Show();
        }
        private void Button_Click_All(object sender, RoutedEventArgs e) //Pozwala na null-owanie daty i pokazanie wszystkich zadań. Powoduje refresh danych.
        {
            date_select.SelectedDate = null;
            RefreshDataSet();
            DeletingPlaceholders();
        }
        private void Button_Click_Check(object sender, RoutedEventArgs e) //Funckja, która sprawdzi i poinformuje o tym czy są zadania w ciągu 7 dni
        {
            var testing = MessageBox.Show("Za chwile sprawdzimy czy jest zadanie w ciągu 7 dni. Powinno ono pojawić się w formie" +
                "powiadomienia toast w dolnej częsci ekranu gdy będą takie zadanie. \n Czy chcesz sprawdzic czy są zadania?"
                , "Sprawdzenie", MessageBoxButton.OKCancel, MessageBoxImage.Question); //informacja czy chcemy z tego skorzystać.
            if (testing == MessageBoxResult.OK) //możemy się nie zgodzić na to.
            {
                DateTime increment = DateTime.Today;
                String res = ""; //string wynikowy.
                for (int i = 0; i < 7; i++) //sprawdzamy 
                {

                    using var context = new TodoContext();
                    context.Database.EnsureCreated();
                    var linker = context.Listers.Where(b => b.Deadline == increment); //może być wiele zadań tego samego dnia.
                    foreach (var item in linker)
                    {
                        res = res + item.Name + " " + item.Deadline + "\n"; //dodajemy je wszystkie do stringa.
                    }
                    increment = increment.AddDays(1);
                }
                if (res.Length == 0) //Jeżeli string ma długość 0, to znaczy że nie ma zadań.
                {
                    ToastContentBuilder builder = new();
                    builder.AddText("Nie ma zadań w z terminem w tym tygodniu!");
                    builder.AddButton(new ToastButtonDismiss());
                    builder.Show();
                }
                else // jeśli ma, to znaczy że zadania istnieją.
                {
                    ToastContentBuilder builder = new();
                    builder.AddText("Oto zadania w tym tygodniu:");
                    builder.AddText(res);
                    builder.AddButton(new ToastButtonDismiss());
                    builder.Show();

                }
            }
        }
        private void Date_select_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshDataSet();
        }
    }
}
