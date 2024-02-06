using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSword : Espadas
{
    void Awake()
    {
        Daño = 5;
        Durabilidad = 131;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ataque de espada de piedra");
    }
}
