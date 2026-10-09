namespace echecs.Metier;

public class Pion : Piece
{
    public Pion(int lig, int col, char coul) : base(lig,col,coul){}
    
    public override bool deplacement()
    {
        return true;
    }
}