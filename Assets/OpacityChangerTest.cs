using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacityChangerTest : MonoBehaviour
{
    public Material target;
    public void UpdateOpacity(float alphaValue)
    {
        Color color = target.color;
        color.a = alphaValue;
        target.color = color;
    }
    public void fuck()
    {
        Debug.Log("FUCK");
    }

}
