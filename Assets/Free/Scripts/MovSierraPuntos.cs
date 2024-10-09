using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.Mathematics;
using UnityEngine;

public class MovSierraPuntos : MonoBehaviour
{
    [SerializeField] List<Transform> puntos;

    [SerializeField] float velocidad;

    int contador = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.rotation = Quaternion.RotateTowards(transform.rotation, puntos[contador].rotation, velocidad * Time.deltaTime);

     if (transform.rotation == puntos[contador].rotation) 
      { 
        if (contador + 1 > puntos.Count -1) 
        {
            contador = 0;
        }
        else 
        {
            contador++;
        }
      }
    }
}
