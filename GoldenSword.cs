using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenSword : Espadas
{
    void Awake()
    {
        Daño = 4;
        Durabilidad = 32;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ataque de espada de oro");
    }
}
