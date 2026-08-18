public class Fou : Piece
{
    public Fou(int lig, int col) : base(lig,col){}

    public override bool deplacement()
    {
        return true;
    }
}