using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSword : Espadas
{
    void Awake()
    {
        Daño = 6;
        Durabilidad = 250;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ataque de espada de hierro");
    }
}
