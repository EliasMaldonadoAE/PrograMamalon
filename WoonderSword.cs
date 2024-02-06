using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoonderSword : Espadas
{
  
    void Awake()
    {
        Daño = 4;
        Durabilidad = 59;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ataque de espada de madera");
    }
}
