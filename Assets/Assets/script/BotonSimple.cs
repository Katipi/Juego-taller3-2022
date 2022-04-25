using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BotonSimple : MonoBehaviour
{
    public UnityEvent evento;
    private void OnMouseUp()
    {
        evento.Invoke();
    }
}
