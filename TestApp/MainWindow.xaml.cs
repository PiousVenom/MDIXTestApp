using System.Windows;

namespace TestApp;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        AddItems();
    }

    private void AddItems()
    {
        CmbTest.Items.Add("Item 1");
        CmbTest.Items.Add("Item 2");
        CmbTest.Items.Add("Item 3");
        CmbTest.Items.Add("Item 4");
        CmbTest.Items.Add("Item 5");
        CmbTest.Items.Add("Item 6");
        CmbTest.Items.Add("Item 7");
    }
}
