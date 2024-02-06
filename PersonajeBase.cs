using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeBase : MonoBehaviour
{
    public bool IsDead;
    protected float health;
}
public class Heroe : PersonajeBase 
{
    //Variable privada de heroe
    private int HeroeAgil;
    private int HeroeFuerte;
    private float Arma;
}
public class Enemigo : PersonajeBase
{
    protected float arquero;
    protected float caballero;
    protected float hechicero;
    protected float explorador;
    protected string ArmaE;

}
public class OtraClase
{
    void AccederPersonaje()
    {
        PersonajeBase nuevoPersonaje = new PersonajeBase();
        bool Moriste = nuevoPersonaje.IsDead;
    }
}

