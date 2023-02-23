using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSetter : MonoBehaviour
{
    public BoardProperties_SO Board;

    public BoardColours_SO BoardColours;     

    public TileProperties_SO Tile;

    public string debugMessage;

    public void GenearateBoard()
    {
        for (int x = 0; x < Board.X.ConstantValue; x++)
        {
            for (int y = 0; y < Board.Y.ConstantValue; y++)
            {

            }
        }
    }

    public void SetBoardMessage()
    {
        debugMessage = "Board is Set";
    }
}
