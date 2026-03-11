using System.Windows;
using System.Windows.Controls;
using ShapesApp.Creators;

namespace ShapesApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            figuresPanel.Children.Clear();

            if (colorComboBox.SelectedItem == null)
                return;

            var selectedItem = (ComboBoxItem)colorComboBox.SelectedItem;
            string colorName = selectedItem.Content.ToString();

            CircleCreator circleCreator;
            SquareCreator squareCreator;
            TriangleCreator triangleCreator;

            switch (colorName)
            {
                case "🔴 Красный":
                case "Красный":
                    circleCreator = new RedCircleCreator();
                    squareCreator = new RedSquareCreator();
                    triangleCreator = new RedTriangleCreator();
                    break;
                case "🔵 Синий":
                case "Синий":
                    circleCreator = new BlueCircleCreator();
                    squareCreator = new BlueSquareCreator();
                    triangleCreator = new BlueTriangleCreator();
                    break;
                case "🟢 Зелёный":
                case "Зелёный":
                    circleCreator = new GreenCircleCreator();
                    squareCreator = new GreenSquareCreator();
                    triangleCreator = new GreenTriangleCreator();
                    break;
                default:
                    return;
            }

           
            figuresPanel.Children.Add(circleCreator.CreateCircle().CreateUIElement(200));
            figuresPanel.Children.Add(squareCreator.CreateSquare().CreateUIElement(200));
            figuresPanel.Children.Add(triangleCreator.CreateTriangle().CreateUIElement(200));
        }
    }
}