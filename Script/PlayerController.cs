using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    
    public float health;
    public float magic;
    //public Text healthDisplay;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private List<GameObject> Mochila = new List<GameObject>();

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            for (int i = 0; i <Mochila.Count; i++)
            {
                if (Mochila[i].GetComponent<Image>().enabled==false)
                {
                    Mochila[i].GetComponent<Image>().enabled = true;
                   
                    break;
                }
            } 
        }
    }
    private void Update()
    {

        //healthDisplay.text = health.ToString();

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
