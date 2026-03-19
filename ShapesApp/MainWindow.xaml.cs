using System.Windows;
using System.Windows.Controls;
using ShapesApp.Factories;

namespace ShapesApp
{
    public partial class MainWindow : Window
    {
        private IFigureFactory currentFactory;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            figuresPanel.Children.Clear();

            if (colorComboBox.SelectedItem == null) return;

            var selectedItem = (ComboBoxItem)colorComboBox.SelectedItem;
            string colorName = selectedItem.Content.ToString();

            switch (colorName)
            {
                case "🔴 Красный":
                case "Красный":
                    currentFactory = new RedFactory();
                    break;
                case "🔵 Синий":
                case "Синий":
                    currentFactory = new BlueFactory();
                    break;
                case "🟢 Зелёный":
                case "Зелёный":
                    currentFactory = new GreenFactory();
                    break;
                default:
                    return;
            }

            figuresPanel.Children.Add(currentFactory.CreateCircle().CreateUIElement(200));
            figuresPanel.Children.Add(currentFactory.CreateSquare().CreateUIElement(200));
            figuresPanel.Children.Add(currentFactory.CreateTriangle().CreateUIElement(200));
        }
    }
}