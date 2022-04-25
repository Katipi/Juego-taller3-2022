using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class VentanaMemorice : MonoBehaviour
{
    public Animator animatorMemorice;
    public Animator animatorPantalla; 
    public SpriteRenderer dulce1, dulce2, dulce3;
    public TextMeshPro txtCantidad1, txtCantidad2, txtCantidad3;
    public int cantidadMaxima;
    public float tiempoDeVisibilidad;
    public Sprite[] productos;

    int cantidadDulce1, cantidadDulce2, cantidadDulce3;
    int producto1, producto2, producto3;


    public void ElegirProductos()
    {
        int elLargo = productos.Length;

        producto1 = Random.Range(0, elLargo);
        producto2 = Random.Range(0, elLargo);

        // mientras producto2 sea igual a producto1?
        // seguir generando numero random para producto 2

        while (producto2 == producto1)
        {
            producto2 = Random.Range(0, elLargo);
        }

        producto3 = Random.Range(0, elLargo);

        // mientras producto 3 sea igual a producto 2 o producto 3 sea igual a producto 1?
        // seguir generando numero random para producto 3

        while (producto3 == producto2 || producto3 == producto1)
        {
            producto3 = Random.Range(0, elLargo);
        }


        // dibujar los sprites en los spriteRenderer
        dulce1.sprite = productos[producto1];
        dulce2.sprite = productos[producto2];
        dulce3.sprite = productos[producto3];

        // DEFINIR CANTIDADES
        cantidadDulce1 = Random.Range(1, cantidadMaxima);
        cantidadDulce2 = Random.Range(1, cantidadMaxima);
        cantidadDulce3 = Random.Range(1, cantidadMaxima);

        // MOstrar Cantidades
        txtCantidad1.text = cantidadDulce1.ToString();
        txtCantidad2.text = cantidadDulce2.ToString();
        txtCantidad3.text = cantidadDulce3.ToString();


        // LLamar Funcion OcultarVentana con el temporizador
        Invoke("OcultarVentana", tiempoDeVisibilidad);

    }

    public void OcultarVentana()
    {
        // OCULTAR LA VENTANA
        // Ejecutar Animacion Ocultar
        animatorMemorice.Play("Ocultar");
        animatorPantalla.Play("aparecer"); 
        //Habilitar ventana del gameplay
    }



}
