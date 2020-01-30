using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageColor : MonoBehaviour {

	public Color averageCol(Texture2D tex)
    {
        var texColors = tex.GetPixels32();
        var total = texColors.Length;
        var r = 0;
        var g = 0;
        var b = 0;
        for (int i = 0; i < total; i++)
        {
            r += texColors[i].r;
            g += texColors[i].g;
            b += texColors[i].b;
        }

        return new Color(r/total, g/total, b/total, 0);
    }
}
