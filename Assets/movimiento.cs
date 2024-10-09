using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
     Rigidbody2D rb;
    public float velocidad;
    public float fuerzaSalto;
    public Transform puntoDeteccion;
    public Vector2 tamañoDeteccion;
    public bool isGrounded;
    public LayerMask deteccion;

    public LayerMask capasSuperficies; 

    Vector3 initPosition;
    float valorHorizontal;
    public float intervaloCambio = 2f; 
    private float temporizador = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initPosition = transform.position;

      
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private void Update()
    {
        Movimiento();
        isGrounded = Physics2D.OverlapBox(puntoDeteccion.position, tamañoDeteccion, 0, deteccion);

        if (isGrounded)
            ProcesarSalto();

       
        temporizador += Time.deltaTime;
        if (temporizador >= intervaloCambio)
        {
            AplicarAjustes();
            temporizador = 0;
        }
    }

    void ProcesarSalto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
        }
    }

    void Movimiento()
    {
        valorHorizontal = Input.GetAxis("Horizontal");

       
        if (valorHorizontal != 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
        }

        rb.velocity = new Vector2(valorHorizontal * velocidad, rb.velocity.y);
    }

    void AplicarAjustes()
    {
        
        RaycastHit2D hit = Physics2D.Raycast(puntoDeteccion.position, Vector2.down, 0.1f, capasSuperficies);

        if (hit.collider != null)
        {
           
            rb.drag = 5f;  
        }
        else
        {
            
            rb.drag = 0f;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(puntoDeteccion.position, tamañoDeteccion);
    }

    public void ResetPosition()
    {
        transform.position = initPosition;
    }

    private void OnEnable()
    {
        isGrounded = Physics2D.OverlapBox(puntoDeteccion.position, tamañoDeteccion, 0, deteccion);
    }
}
