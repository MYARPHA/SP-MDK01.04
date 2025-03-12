using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectFolderButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FolderPathTextBox.Text = dialog.SelectedPath;
                FindDuplicates(dialog.SelectedPath);
            }
        }

        private void FindDuplicates(string folderPath)
        {
            ViewFilesDataGrid.Items.Clear();

            // Получение списка файлов
            var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)
                .Select(f => new FileInfo(f)).ToList();

            // Опредление критерий поиска
            Dictionary<string, List<FileInfo>> duplicates = new Dictionary<string, List<FileInfo>>();
            string critery = CrtireryComboBox.SelectedItem.ToString();

            if (critery == "Имя")
                duplicates = files.GroupBy(f => f.Name)
                    .Where(g => g.Count() > 1)
                    .ToDictionary(g => g.Key.ToString(), g => g.ToList());
        }

        private void DeleteFilesButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}