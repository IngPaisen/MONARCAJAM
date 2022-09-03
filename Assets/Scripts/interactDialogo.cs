using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class interactDialogo : MonoBehaviour
{

    bool hablando, primeraVez;
    [SerializeField]TextMeshProUGUI text;
    //[SerializeField] BarraCarga barra;
    MoveController player;
    //[SerializeField] Image backGround;
    //[SerializeField] Image fill;
    public int caso;
    [SerializeField]GameObject panel;
    //public Image basura;
    // Start is called before the first frame update

    void Start()
    {
        text = GameObject.Find("TextHablar").GetComponent<TextMeshProUGUI>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MoveController>();

    }

    private void Update()
    {
        if (hablando)
        {
            player.speed = 0;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.CompareTag("Player") && !primeraVez)
        {
            text.enabled = true;

            if (Input.GetKeyDown(KeyCode.E)&&!hablando)
            {

                player.speed = 0;
                
                hablando = true;
                panel.SetActive (true);
            }
            else if (Input.GetKeyDown(KeyCode.E) && hablando)
            {
                hablando = false;
                panel.SetActive(false);

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


    private void OnTriggerExit(Collider other)
    {
        text.enabled = false;

    }
}
