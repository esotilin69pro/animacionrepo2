using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CausarDaño : MonoBehaviour
{
    [SerializeField] float daño = 10f;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        controlvida vidaPersonaje = collision.collider.GetComponent<controlvida>();

        if (vidaPersonaje != null)
        {
            vidaPersonaje.recibirdaño(daño);
        }
    }

}
