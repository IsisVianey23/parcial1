using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    private Inventory inventory; //llama al inventario


    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();//accede al inventario del player
    }

    private void OnTriggerEnter2D(Collider2D other)//almacena y destruye el objeto
    {
        if (other.CompareTag("Player")) 
        {
            for (int i = 0; i < inventory.items.Length; i++) //el bucle continua mientras sea menor al numero de items
            {
                if (inventory.items[i] == 0) //verifica si el inventario esta vacio
                {
                    inventory.items[i] = 1;
                    Destroy(gameObject);
                    break;
                }
            }
        }
        
    }
}
