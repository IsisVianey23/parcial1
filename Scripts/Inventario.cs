using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
        public List<GameObject> Mochila = new List<GameObject>();
        public GameObject inv;
        public bool Activar_Inventario;

        void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.CompareTag("Item"))
            {
                for (int i = 0; i < Mochila.Count; i++)
                {
                    Mochila[i].GetComponent<Image>().enabled = true;
                    Mochila[i].GetComponent<Image>().sprite = coll.GetComponent<SpriteRenderer>().sprite;
                    break;
                }
            }
        }

        void Start()
        {

        }
        void Update()
        {
            if (Activar_Inventario)
            {
                inv.SetActive(true);
            }
            else
            {
                inv.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Activar_Inventario = !Activar_Inventario;
            }
        }
    }

