using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNdrop : MonoBehaviour
{
    public SpriteRenderer spriterenderer;
    public bool onDrag;
    Vector3 posicionOriginal;

    private void Awake()
    {
        spriterenderer.enabled = false; 
        posicionOriginal = transform.position;

    }
    private void OnMouseDrag()
    {
        spriterenderer.enabled = true; 
        onDrag = true; 
        Vector3 posicionMouse = Input.mousePosition;
        posicionMouse.z = 10;
        Vector3 posicionCorregida = Camera.main.ScreenToWorldPoint(posicionMouse);

        transform.position = posicionCorregida;

    }

    private void OnMouseUp()
    {
        onDrag = false; 
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (onDrag == false)
        {
            if(collision.CompareTag("canasta"))
            {
                // apagar el spriterenhderer
                // devolver a la posicionm inicial
                transform.position = posicionOriginal;
                spriterenderer.enabled = false;  

            }

        }
    }

}
