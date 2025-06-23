using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color[] colors;
    public Renderer cubeRenderer;
    public int randomColorIndex;

    // Start is called before the first frame update
    void Start()
    {
        // randomColorIndex = Random.Range(0, colors.Length);
        // cubeRenderer.material.color = colors[randomColorIndex];
        // Usar invoke repeating para cambiar el color de manera aleatoria
        // Cada medio segundo
        InvokeRepeating("CambiarDeColor", 0, 0.5f);
    }
        void CambiarDeColor()
        {
            randomColorIndex = Random.Range(0, colors.Length);
            cubeRenderer.material.color = colors[randomColorIndex];
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
