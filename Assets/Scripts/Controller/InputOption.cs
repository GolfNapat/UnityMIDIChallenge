using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/InputOption")]
public class InputOption : ScriptableObject
{
    public inputKey thisKey;

    public virtual void SoundTrim()
    {

    }
}

public enum inputKey { aInputKey, sInputKey, dInputKey, fInputKey, gInputKey, hInputKey }

