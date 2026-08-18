public class Queen : Piece
{
    public Queen(int lig, int col) : base(lig,col){}

    public override bool deplacement()
    {
        return true;
    }
}