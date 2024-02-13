using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    
    public float health;
    public float magic;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity; //almacena la dirección y velocidad de movimiento del jugador
    private List<GameObject> Mochila = new List<GameObject>(); //lista privada que almacena los objetos recogidos por el player

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)// el metodo OnTriggerEnter2D se llama cuando un collider choca con el collider de tipo Trigger de otro GameObject
    {
        if (collision.CompareTag("Item")) //verifica si el objeto con el que el player ha chocado tiene la etiqueta "Item"
        {
            for (int i = 0; i <Mochila.Count; i++)//almacenar los items del inventario
            {
                if (Mochila[i].GetComponent<Image>().enabled==false)//desactiva la imagen que tiene el slot
                {
                    Mochila[i].GetComponent<Image>().enabled = true;//activa la imagen remplazandola con el sprite del item recolectado
                   
                    break;
                }
            } 
        }
    }
    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); // crea un nuevo vector (moveInput) utilizando los valores de los ejes H Y v
        moveVelocity = moveInput.normalized * speed; //calcula la direccion y la velocidad del movimiento
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);//el movimiento sea mas suave
    }
}
