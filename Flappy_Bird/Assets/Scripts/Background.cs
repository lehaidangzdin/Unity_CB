using UnityEngine;

public class Background : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 2f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed + Time.deltaTime, 0);
    }
}
