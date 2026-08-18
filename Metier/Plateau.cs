public class Plateau
{
    private const int NB_LIG = 8;
    private const int NB_COL = 8;
    private List<Piece> lstPiece = new List<Piece>();

    public static int getNbLig (){return NB_LIG;}
    public static int getNbCol (){return NB_COL;}

    public override string ToString()
    {
        string res ="";
        for (int col = 0; col  < NB_COL; col++)
        {
            res += " __";
        }
        res+= "\n";
        for (int col = 0; col  < NB_COL; col++)
        {
            for(int lig = 0; lig < NB_LIG; lig++)
                res += "|__";
            res += "|\n";
        }

        return res;

    }

}