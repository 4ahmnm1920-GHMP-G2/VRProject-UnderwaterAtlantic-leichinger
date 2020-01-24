﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class UnderWaterEffect : MonoBehaviour
{
    public Material _mat;
    [Range(0.001f, 0.1f)]
    public float _pixelOffset;
    [Range(0.1f, 20f)]
    public float _noiseScale;
    [Range(0.1f, 20f)]
    public float _noiseFrequency;
    [Range(0.1f, 30f)]
    public float _noiseSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _mat.SetFloat("NoiseFrequency", _noiseFrequency);
        _mat.SetFloat("NoiseSpeed", _noiseSpeed);
        _mat.SetFloat("NoiseScale", _noiseScale);
        _mat.SetFloat("_PixelOffset", _pixelOffset);
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest) 
    {
        Graphics.Blit(src, dest, _mat);
    }
}
