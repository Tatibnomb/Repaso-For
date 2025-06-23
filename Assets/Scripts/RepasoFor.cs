using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        // Escribir en consola desde el 0 hasta el 4
        // for (int i = 0; i < 5; i++)
        // {
        // Debug.Log(i);
        // }

        // escribir los multiplos de 3 hasta el 30 inclusive
        // for (int i = 3; i <= 30; i += 3)
        // {
        // Debug.Log(i);
        // }

        // Escribir los enteros desde y hasta dos numeros ingresados por inspector
        // for (int i = num1; i <= num2; i++)
        // {
        // Debug.Log(i);
        // }

        // Escribir los enteros desde 25 hasta 4 exepto el 13
        for (int i = 25; i >= 4; i--)
        {
            if (i == 13)
            {
                continue;
            }
            Debug.Log(i);
        }
    }
}