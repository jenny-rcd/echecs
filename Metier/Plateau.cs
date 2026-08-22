using System;
using System.Collections.Generic;

public class Plateau
{
    private const int NB_LIG = 8;
    private const int NB_COL = 8;
    private List<Piece> lstPiece = new List<Piece>();

    public static int getNbLig (){return NB_LIG;}
    public static int getNbCol (){return NB_COL;}

    public void initPiece()
    {

        for(int col = 0; col < NB_COL; col++)
        {
            //ajout des pions
            this.lstPiece.Add(new Pion(1,col));
            this.lstPiece.Add(new Pion(6,col));

            //ajout des tours
            if(col == 0 || col == NB_COL - 1)
            {
                this.lstPiece.Add(new Tour(0,col));
                this.lstPiece.Add(new Tour(7,col));
            }

            //ajout des cavaliers
            if(col == 1 || col == NB_COL - 2)
            {
                this.lstPiece.Add(new Cavalier(0,col));
                this.lstPiece.Add(new Cavalier(7,col));
            }

            //ajout des Fous
            if(col == 2 || col == NB_COL - 3)
            {
                this.lstPiece.Add(new Fou(0,col));
                this.lstPiece.Add(new Fou(7,col));
            }

        }
        //ajout des rois et des reines
        this.lstPiece.Add(new King (0,4));
        this.lstPiece.Add(new King (7,4));
        this.lstPiece.Add(new Queen(0,3));
        this.lstPiece.Add(new Queen(7,3));
    }

    public override string ToString()
    {
        initPiece();
        string res ="";
        int cpt = 0; // permet de voir si une piece a été mise a cette endroit
        for (int col = 0; col  < NB_COL; col++)
        {
            res += " --";
        }
        res+= "\n";
        for (int lig = 0; lig  < NB_LIG; lig++)
        {
            for(int col = 0; col < NB_COL; col++)
            {
                cpt = 0;
                res += "| ";
                foreach (Piece piece in this.lstPiece)
                {
                    if (piece.getCol() == col && piece.getLig() == lig)
                    {
                        res += piece.GetType().Name[0];
                        break;
                    }
                    else
                    {
                        cpt++;
                    }
                }

                if(cpt == this.lstPiece.Count())
                {
                    res += " ";
                }
                
            }
            res += "|\n";

            for (int col1 = 0; col1  < NB_COL; col1++)
            {
                res += " --";
            }
            res+= "\n";     
        }

        return res;

    }

}