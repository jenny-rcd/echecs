namespace echecs.Metier;

public class Tour : Piece
{
    public Tour(int lig, int col, char coul) : base(lig,col,coul){}

    public override bool deplacement()
    {
        return true;
    }
}