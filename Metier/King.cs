namespace echecs.Metier;

public class King : Piece
{
    public King(int lig, int col, char coul) : base(lig,col, coul){}

    public override bool deplacement()
    {
        return true;
    }
}