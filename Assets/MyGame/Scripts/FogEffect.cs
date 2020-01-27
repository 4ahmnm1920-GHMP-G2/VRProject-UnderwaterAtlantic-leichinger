using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class FogEffect : MonoBehaviour
{   public Material _mat;
    public Color _fogColor;
    public float _depthSart;
    public float _depthDistance;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
    }

    // Update is called once per frame
    void Update()
    {
        _mat.SetColor("_FogColor", _fogColor);
        _mat.SetFloat("_DepthSart", _depthSart);
        _mat.SetFloat("_DepthDistance", _depthDistance);

    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest) 
    {
        Graphics.Blit(src, dest, _mat);
    }
}
