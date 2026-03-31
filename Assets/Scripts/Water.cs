
using UnityEngine;

public class Water : MonoBehaviour
{
    public Color color = Color.blue;

    void Start()
    {
        // Get the Renderer component from the plane
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            // Create a new material instance and assign the color
            renderer.material.color = color;
        }
    }
}