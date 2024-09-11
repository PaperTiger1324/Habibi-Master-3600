using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    [SerializeField] private List<Parallax> _parallaxLayers;

    private void Awake()
    {
        foreach (Parallax layer in _parallaxLayers)
        {
            layer.MeshRenderer.material.SetTexture("_MainTex", layer.Texture);
            layer.MeshRenderer.material.mainTextureScale = new Vector2(layer.TextureScale, layer.TextureScale);
        }
    }
    private void Update()
    {
        foreach (Parallax layer in _parallaxLayers)
        {
            Vector2 offset = new Vector2(transform.position.x / transform.localScale.x / layer.Slowness, 0);
            layer.MeshRenderer.material.mainTextureOffset = offset;

        }
    }
}
