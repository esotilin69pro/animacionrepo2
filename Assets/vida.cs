using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlvida : MonoBehaviour
{
    [SerializeField] float vida=10f;
    [SerializeField] float vidamaxima=10f;
    private Vector3 posicioninicial;

    private void Start()
    {
        posicioninicial = transform.position;   
    }

    public void recibirdaño(float daño)
    {
        vida -= daño;

        if(vida <= 0)
        {
            Debug.Log("el personaje murio");
            volverposcisioninicial();  
        }  
    }
    public void recibircura(float cura)
    {
        vida += cura;
        if (vida > vidamaxima) vida = vidamaxima;
        Debug.Log("personaje recibio cura:"+cura+".vida actual:"+vida);
    }
    private void volverposcisioninicial()
    {
      transform.position=posicioninicial;
        vida = vidamaxima;
    }
}
