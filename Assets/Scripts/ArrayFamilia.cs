using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayFamilia : MonoBehaviour
{
    public int[] edadesFamilia;
    int sumaEdades = 0;
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

        // Escribir el promedio de los elementos del array
        for (int i = 0; i < edadesFamilia.Length; i++)
        {
            sumaEdades += edadesFamilia[i];
        }
        float promedio = sumaEdades / edadesFamilia.Length;
        Debug.Log(promedio);

        // Escribir los elementos del array mayores que 20
        for (int i = 0; i < edadesFamilia.Length; i++)
        {
            if (edadesFamilia[i] > 20)
            {
                Debug.Log(edadesFamilia[i]);
            }
        }

        // Escribir los elementos del array en orden inverso
        for (int i = edadesFamilia.Length - 1; i >= 0; i--)
        {
            Debug.Log(edadesFamilia[i]);
        }
    }

    // Update is called once per frame
    void Update()
        {

        }
}