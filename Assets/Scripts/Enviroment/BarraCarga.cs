using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraCarga : MonoBehaviour
{
    public Image fill;
    public float max;
    public float actual;
    public int caso;
    GameManager gameManager;
    bool primeraVez;
    [SerializeField]Interact interactuado;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();

    }
    private void Update()
    {
       
    }

    public void cargar(float adicion)
    {
        Debug.Log("ejecutando");
        if (actual < max)
        {
            actual += adicion;
            fill.fillAmount = actual / max;
        }
        else
        {
            RegresarValor();
        }
    }
     
    
    public bool RegresarValor()
    {
        switch (caso)
        {
            case 0:
                gameManager.tarea1 = true;
                primeraVez = true;
                interactuado.VoltearValor();
                return true;


            case 1:
                gameManager.tarea2 = true;
                primeraVez = true;
                interactuado.VoltearValor();

                return true;


        }

        return false;
    }

}
