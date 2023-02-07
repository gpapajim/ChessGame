using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FloatReference
{
    public bool UseConstant = true;
    public float ConstantValue;
    public FloatVariable Variable;

    public float Value()
    {
        if (UseConstant)
            return ConstantValue;

        else
            return Variable.Value; 
    }
}
