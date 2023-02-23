using UnityEngine;


[CreateAssetMenu(fileName = "BoardColours",menuName = "Board Colours")]
public class BoardColours_SO : ScriptableObject
{
    [Header("Colours for the board tiles")]
    public Color first;
    public Color second;

    [TextArea]
    public string Notes;
}
