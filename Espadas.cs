using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espadas : MonoBehaviour
{
    public int Daño;
    public int Durabilidad;
    protected SpriteRenderer swordSpriteRenderer;
    public virtual void Ataque()
    {
        Debug.Log("Ataque");

    }
}

