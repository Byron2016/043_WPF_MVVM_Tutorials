using aab_EventCommandsMVVM.ViewModels;
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

namespace aab_EventCommandsMVVM.Views
{
    /// <summary>
    /// Interaction logic for TodoList.xaml
    /// </summary>
    public partial class TodoList : UserControl
    {
        //Using DependencyProperty
        public static readonly DependencyProperty LoadCommandProperty = DependencyProperty.Register("LoadCommand", typeof(ICommand), typeof(TodoList), new PropertyMetadata(null));

        public ICommand LoadCommand
        {
            get { return (ICommand)GetValue(LoadCommandProperty); }
            set {SetValue(LoadCommandProperty, value); }
        }

        public TodoList()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //(DataContext as TodoListViewModel).LoadTodoItemsCommand.Execute(null);

            if(LoadCommand != null)
            {
                LoadCommand.Execute(this);  
            }
        }
    }
}
