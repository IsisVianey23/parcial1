using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioActivado : Inventario
{
   
    public bool Activar_Inventario;

    // Update is called once per frame
    void Update()
    {
        if ( Activar_Inventario )
        {
            inv.SetActive( true );
        }
        else 
        { 
            inv.SetActive( false ); 
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Activar_Inventario = !Activar_Inventario;
        }

    }
}
