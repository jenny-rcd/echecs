namespace echecs.Metier;

public class Queen : Piece
{
    public Queen(int lig, int col, char coul) : base(lig,col, coul){}

    public override bool deplacement()
    {
        return true;
    }
}