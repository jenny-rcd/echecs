namespace echecs.Metier;

public class Fou : Piece
{
    public Fou(int lig, int col, char coul) : base(lig,col,coul){}

    public override bool deplacement()
    {
        return true;
    }
}