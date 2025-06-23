using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayFamilia : MonoBehaviour
{
    public int[] edadesFamilia;
    // Start is called before the first frame update
    void Start()
    {
        // Escribir el primer elemento del array
        Debug.Log(edadesFamilia[0]);

        // Escribir la cantidad de elementos del array
        Debug.Log(edadesFamilia.Length);

        // Escribir todos los elementos del array
        for (int i = 0; i < edadesFamilia.Length; i++)
        {
            Debug.Log(edadesFamilia[i]);
        }

        // Escribir los elementos del array mayores que 20
        for (int i = 0; i > 20; i++)
        {
            Debug.Log(edadesFamilia[i]);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}