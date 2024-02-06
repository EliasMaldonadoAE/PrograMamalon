using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perro : Animal
{
    [Header ("CLASE DERIVADA")]
    public string Raza;


    
    void Start()
    {
        Display();
    }

    public override void move()
    {
        
        //Posicion del Mouse
        posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouse.z = 0f;
        // Calcular la dure3ccion y normalizarla
        Vector3 direccion = (posicionMouse - transform.position).normalized;

        // Mover al objeto a la dfireccion calculada
        transform.Translate(direccion * speed * Time.deltaTime);
    }


    // Update is called once per frame
    public void Update()
    {
        move();
    }
}
