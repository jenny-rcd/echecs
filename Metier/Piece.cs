namespace echecs.Metier;

public abstract class Piece
{
    public int lig { get; set; }
    public int col { get; set; }
    public char coul { get; set; }

    public string CheminImage
    {
        get
        {
            // 1. Récupère automatiquement "Cavalier", "Tour", "Pion", etc.
            string nomPiece = this.GetType().Name; 

            // 2. Détermine la lettre de la couleur (B ou N)
            // (Adaptez cette ligne selon la façon dont est stockée votre couleur, ex: "Blanc" ou une Enum)
            string lettreCouleur = "" + this.coul;

            // 3. Retourne l'adresse complète calculée
            // Remplacez "echecs" par le nom exact de votre projet/assembly
            return $"avares://IHM/Assets/{nomPiece}_{lettreCouleur}.svg";
        }
    }

    public Piece (int lig, int col, char coul)
    {
        this.lig  = lig;
        this.col  = col;
        this.coul = coul;
    }
    
    public bool deplacementValide() // verifie si le déplacement est possible
    {
        return this.lig <= Plateau.getNbLig() && this.lig >= 0 &&
               this.col <= Plateau.getNbCol() && this.col >= 0;
    }
    
    public abstract bool deplacement(); //déplacement a effectuer

    public int getLig(){return this.lig;}
    public int getCol(){return this.col;}
}