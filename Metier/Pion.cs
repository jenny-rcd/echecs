public class Pion : Piece
{
    public Pion(int lig, int col) : base(lig,col){}
    
    public override bool deplacement()
    {
        return true;
    }
}