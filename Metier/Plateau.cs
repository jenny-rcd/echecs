using System;
using System.Collections.Generic;
namespace echecs.Metier;

public class Plateau
{
    private const int NB_LIG = 8;
    private const int NB_COL = 8;
    private List<Piece> lstPiece = new List<Piece>();

    public static int getNbLig (){return NB_LIG;}
    public static int getNbCol (){return NB_COL;}

    public List<Piece> initPiece()
    {

        for(int col = 0; col < NB_COL; col++)
        {
            //ajout des pions
            this.lstPiece.Add(new Pion(1,col,'N'));
            this.lstPiece.Add(new Pion(6,col,'B'));

            //ajout des tours
            if(col == 0 || col == NB_COL - 1)
            {
                this.lstPiece.Add(new Tour(0,col,'N'));
                this.lstPiece.Add(new Tour(7,col,'B'));
            }

            //ajout des cavaliers
            if(col == 1 || col == NB_COL - 2)
            {
                this.lstPiece.Add(new Cavalier(0,col,'N'));
                this.lstPiece.Add(new Cavalier(7,col,'B'));
            }

            //ajout des Fous
            if(col == 2 || col == NB_COL - 3)
            {
                this.lstPiece.Add(new Fou(0,col,'N'));
                this.lstPiece.Add(new Fou(7,col,'B'));
            }

        }
        //ajout des rois et des reines
        this.lstPiece.Add(new King (0,4,'N'));
        this.lstPiece.Add(new King (7,4,'B'));
        this.lstPiece.Add(new Queen(0,3,'N'));
        this.lstPiece.Add(new Queen(7,3,'B'));

        return this.lstPiece;
    }

    public override string ToString()
    {
        initPiece();
        string res ="";
        for (int lig = 0; lig  < NB_LIG; lig++)
        {
            for(int col = 0; col < NB_COL; col++)
            {
                foreach (Piece piece in this.lstPiece)
                {
                    if (piece.getCol() == col && piece.getLig() == lig)
                    {
                        res += piece.GetType().Name[0];
                        break;
                    }
                    else
                    {
                        res += " . ";
                    }
                }
            }
            res += "\n";
     
        }

        return res;

    }

}