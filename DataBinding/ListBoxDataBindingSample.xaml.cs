using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFControls
{
    /// <summary>
    /// Interaction logic for ListBoxDataBindingSample.xaml
    /// </summary>
    public partial class ListBoxDataBindingSample : Window
    {
        public ListBoxDataBindingSample()
        {
            InitializeComponent();
            List<ToDoItem> items = new List<ToDoItem>();
            items.Add(new ToDoItem("Afwas", 58));
            items.Add(new ToDoItem("Eten", 88));
            items.Add(new ToDoItem("Slapen", 18));

            lbTodoList.ItemsSource = items;
        }
    }
    public class ToDoItem
    {
        public ToDoItem(string title, int completion)
        {
            Title = title;
            Completion = completion;
        }

        public string Title { get; set; }
        public int Completion { get; set; }
    }
}
