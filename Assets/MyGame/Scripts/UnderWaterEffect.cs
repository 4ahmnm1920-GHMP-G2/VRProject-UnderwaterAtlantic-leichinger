using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public Material _mat;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class UnderWaterEffect : MonoBehaviour
{  
     private void OnRenderImage(RenderTexture src, RenderTexture dest) 
    {
        Graphics.Blit(source,destination,_mat);
    }
}
