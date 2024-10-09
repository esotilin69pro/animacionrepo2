using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurarPersonaje : MonoBehaviour
{
    [SerializeField] float cura = 20f;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        controlvida vidaPersonaje = collision.GetComponent<controlvida>();

        if (vidaPersonaje != null)
        {
            vidaPersonaje.recibircura(cura);
            Debug.Log("El personaje ha sido curado.");

            
            spriteRenderer.enabled = false;

           
            Destroy(gameObject, 1f);
        }
    }
}
