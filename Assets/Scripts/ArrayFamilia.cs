using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayFamilia : MonoBehaviour
{
    public string[] integrantesFamilia;
    // Start is called before the first frame update
    void Start()
    {
        // Escribir el primer elemento del array
        Debug.Log(integrantesFamilia[0]);
    
        // Escribir la cantidad de elementos del array
        Debug.Log(integrantesFamilia.Length);

        // Escribir todos los elementos del array
        for (int i = 0; i < integrantesFamilia.Length; i++)
        {
            Debug.Log(integrantesFamilia[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
