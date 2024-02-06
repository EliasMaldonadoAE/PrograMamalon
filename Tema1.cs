using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema1 : MonoBehaviour
{
    //Variable: es contenedor de informacion.
    public int edad = 30;
    void Start()
    {
        int resultado = suma(5, 5);
        Debug.Log("El resultado es:" + resultado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int suma(int x, int y)
    {
        return x + y;
    }
    
      
}
