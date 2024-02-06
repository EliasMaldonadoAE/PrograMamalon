using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [Header ("CLASE BASE")]
    public string Name = "Animal";
    public float speed = 5f;
    public Vector3 posicionMouse;
    public virtual void move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Posicion del Mouse
            posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionMouse.z = 0f;

        }
            // Calcular la dure3ccion y normalizarla
            Vector3 direccion = (posicionMouse - transform.position).normalized;

            // Mover al objeto a la dfireccion calculada
            transform.Translate(direccion * speed * Time.deltaTime);
    }
        

    
     public virtual void  Display()
    {
        Debug.Log("El nombre del animal es:" + Name);
    }
}   
