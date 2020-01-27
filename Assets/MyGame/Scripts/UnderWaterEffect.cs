using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode ]
public class UnderWaterEffect : MonoBehaviour
{
    public Material _mat;

    [Range(0.001f, 0.01f)]
    public float _pixelOffset;
    [Range(0.1f,20f)]
    public float _noiseScale;
    [Range(0.1f,20f)]
    public float _noiseFrequency;
    [Range(0.1f,30f)]
    public float _noiseSpeed;
    
    public float _depthSart;
    public float _depthDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _mat.SetFloat("_NoiseFrequency", _noiseFrequency);
        _mat.SetFloat("_NoiseScale", _noiseScale);
        _mat.SetFloat("_NoiseSpeed", _noiseSpeed);
        _mat.SetFloat("_PixelOffset", _pixelOffset);
       
        _mat.SetFloat("_DepthSart", _depthSart);
        _mat.SetFloat("_DepthDistance", _depthDistance);

    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest) 
    {
        Graphics.Blit(src, dest, _mat);
    }
}
