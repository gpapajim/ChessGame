using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSetter : MonoBehaviour
{
    
    public BoardColours_SO BoardColours;

    public TileProperties_SO Tile;

    public string debugMessage;

    public void SetBoardMessage()
    {
        debugMessage = "Board is Set";
    }
}
