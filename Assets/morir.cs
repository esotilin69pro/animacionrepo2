using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CausarDa�o : MonoBehaviour
{
    [SerializeField] float da�o = 10f;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        controlvida vidaPersonaje = collision.collider.GetComponent<controlvida>();

        if (vidaPersonaje != null)
        {
            vidaPersonaje.recibirda�o(da�o);
        }
    }

}
