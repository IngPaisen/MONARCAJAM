using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    bool interactuado,primeraVez;
    TextMeshProUGUI text;
    public float adicion;
    [SerializeField]BarraCarga barra;
    MoveController player;
    [SerializeField] Image backGround;
    [SerializeField] Image fill;
    public int caso;

    private void Start()
    {
        text = GameObject.Find("TextInteractuar").GetComponent<TextMeshProUGUI>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MoveController>();
        //barra = GameObject.Find("BarraCarga").GetComponent<BarraCarga>();
        //barraI1 = GameObject.Find("BarraCarga").GetComponent<Image>();
        //barraI2 = GameObject.Find("BarraCarga").GetComponent<Image>();

    }
    private void Awake()
    {
        
    }

    private void Update()
    {
        if (interactuado)
        {
            //text.enabled = false;
            backGround.enabled = false;
            fill.enabled = false;
            player.speed = 10;

        }



    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.CompareTag("Player")&&!interactuado)
        {
            text.enabled = true;
            backGround.enabled = true;
            fill.enabled = true;
            if (Input.GetKey(KeyCode.E))
            {
                player.speed = 0;
                //reproducir audio de Tarea
                barra.cargar(adicion);


            }
            else
            {
                player.speed = 10;
            }
        }
        else
        {
            text.enabled = false;

        }
    }


    public void VoltearValor()
    {
        interactuado = true;
    }
    



    private void OnTriggerExit(Collider other)
    {
        text.enabled = false;
        backGround.enabled = false;
        fill.enabled = false;

    }

}
