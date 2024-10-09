using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MovSierra : MonoBehaviour
{
    [SerializeField] Vector3 rotacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotacion * Time.deltaTime, Space.World);
    }
}
