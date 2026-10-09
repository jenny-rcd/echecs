using System.Collections.ObjectModel;
namespace echecs.IHM.ViewModels;
using echecs.Metier;

public class MainViewModels
{
    private Plateau plateau = new Plateau();
    public ObservableCollection<Piece> Pieces { get; set; }

    public MainViewModels()
    {
        // Ici, C# autorise l'accès à 'plateau'
        Pieces = new ObservableCollection<Piece>(plateau.initPiece());
    }
}