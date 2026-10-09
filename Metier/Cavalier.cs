namespace echecs.Metier;

public class Cavalier : Piece
{
    public Cavalier(int lig, int col, char coul) : base(lig,col, coul){}

    public override bool deplacement()
    {
        return true;
    }
}