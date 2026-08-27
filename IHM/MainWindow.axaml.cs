using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Layout;

namespace IHM;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        for (int lig = 0; lig < 8; lig++)
        {
            for (int col = 0; col < 8; col++)
            {
                var cases = new Button
                {
                    Background = (lig + col) % 2 == 0 ? Brushes.Beige : Brushes.Brown,
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    Tag = (lig,col),
                    Classes = { "case-echecs" }
                };
                ChessBoard.Children.Add(cases);
            }
        }
    }
}