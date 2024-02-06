using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSword : Espadas
{
    void Awake()
    {
        Daño = 7;
        Durabilidad = 1561;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ataque de espada de diamante");
    }
}
