using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public SquareRuntimeSet Set;

    private void OnEnable()
    {
        Set.Add(this);
    }

    private void OnDisable()
    {
        Set.Remove(this);
    }
}
