using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool tarea0, tarea1,tarea2, tarea2P5, tarea3;
    [Header("Objetos Clave")]
    public Image basura;


    public void ActivarBasura()
    {
        basura.enabled = !basura.enabled;
    }
}
