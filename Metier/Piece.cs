public abstract class Piece
{
    private int lig;
    private int col;

    public Piece (int lig, int col)
    {
        this.lig = lig;
        this.col = col;
    }
    
    public bool deplacementValide() // verifie si le déplacement est possible
    {
        return this.lig <= Plateau.getNbLig() && this.lig >= 0 &&
               this.col <= Plateau.getNbCol() && this.col >= 0;
    }
    
    public abstract bool deplacement(); //déplacement a effectuer
}