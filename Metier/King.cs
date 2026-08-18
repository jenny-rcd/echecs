public class King : Piece
{
    public King(int lig, int col) : base(lig,col){}

    public override bool deplacement()
    {
        return true;
    }
}