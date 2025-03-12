using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace SearchFileApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string selectFolder = Environment.CurrentDirectory; // текущая папка(по умолч)


        public MainWindow()
        {
            InitializeComponent();
            SelectFolderLabel.Content = $"Текущий каталог: {selectFolder}";
        }

        private void SelectFolderButton_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    selectFolder = dialog.SelectedPath;
                    SelectFolderLabel.Content = $"Выбранный каталог: {selectFolder}";
                }
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            FileResultsListBox.Items.Clear();

            string filePathPart = FileAppTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(filePathPart))
            {
                MessageBox.Show("Введите часть имени файла","", MessageBoxButton.OK);
                return;
            }
            try
            {
                string[] files;

                if (CurrentFolderRadioButton.IsChecked == true)
                {
                    files = Directory.GetFiles(selectFolder, $"*{filePathPart}*");
                }
                else
                {
                    files = Directory.GetFiles(selectFolder, $"*{filePathPart}*", SearchOption.AllDirectories);
                }




                if (files.Length > 0)
                {
                    foreach (var file in files)
                    {
                        FileResultsListBox.Items.Add(file); // добавление найденного файла
                    }
                }
                else
                {
                    MessageBox.Show("Файлы не найдены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
