using UnityEngine;


[CreateAssetMenu(fileName = "TileColours",menuName = "TileColours")]
public class BoardColours_SO : ScriptableObject
{
    [Header("Colours for the board tiles")]
    public Color first;
    public Color second;

    [TextArea]
    public string Notes;
}
