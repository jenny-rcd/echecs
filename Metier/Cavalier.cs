public class Cavalier : Piece
{
    public Cavalier(int lig, int col) : base(lig,col){}

    public override bool deplacement()
    {
        return true;
    }
}