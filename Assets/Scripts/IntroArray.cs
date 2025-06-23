using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroArray : MonoBehaviour
{
    public int[] edades;
    // Start is called before the first frame update
    void Start()
    {
        // Escribir el primer elemento del array
        Debug.Log(edades[0]);

        // Escribir la cantidad de elementos del array
        Debug.Log(edades.Length);

        // Escribir el último elemento del array
        Debug.Log(edades[edades.Length - 1]);

        // Escribir todos los elementos del array
        for (int i = 0; i < edades.Length; i++)
        {
            Debug.Log(edades[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
