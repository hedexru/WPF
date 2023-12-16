using Intuit.Ipp.Data;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp2.Model;

namespace WpfApp2
{
    public partial class PageEmployee : Page
    {
        private bool isDirty = true; // Предположим, что это флаг для проверки изменений
        public static TitleEmployeeEntities DataEntitiesEmployee { get; } = new TitleEmployeeEntities();
        ObservableCollection<Employee> ListEmployee;

        public static RoutedCommand EditCommand = new RoutedCommand();

        public PageEmployee()
        {
            InitializeComponent();
            // Инициализация коллекции ListEmployee
            ListEmployee = new ObservableCollection<Employee>();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var employees = DataEntitiesEmployee.Employee;
            var queryEmployee = from Employee in employees
                                orderby Employee.Surname
                                select Employee;
            foreach (Employee emp in queryEmployee)
            {
                ListEmployee.Add(emp);
            }
            DataGridEmployee.ItemsSource = ListEmployee;
        }



        private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Отмена");
            isDirty = true; // Пометка о наличии изменений
        }

        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty; // Разрешить отмену только если есть изменения
        }

        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Логика создания нового элемента или записи
        }

        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Логика проверки возможности создания нового элемента
        }

        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Логика сохранения
        }

        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Логика проверки возможности сохранения
        }

        private void EditCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Логика редактирования
        }

        private void EditCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Логика проверки возможности редактирования
        }

        private void FindCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Логика для выполнения команды Find
            // Например, обработка поиска сотрудников
        }

        private void FindCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Указание на то, может ли выполняться команда Find
            // Например, установка условий, при которых команда доступна (true) или нет (false)
        }
    }
}
