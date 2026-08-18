public class Tour : Piece
{
    public Tour(int lig, int col) : base(lig,col){}

    public override bool deplacement()
    {
        return true;
    }
}