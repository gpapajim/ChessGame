using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public CircleRuntimeSet Set;

    private void OnEnable()
    {
        Set.Add(this);
    }

    private void OnDisable()
    {
        Set.Remove(this);
    }
}
