using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public CharacterController cController;
    public Transform groundCheck;

    public float speed = 10f;
    public float maxSpeed = 20f;
    public float gravity = -9.81f;
    public float sphereRadius = 0.2f;

    bool isGrounded;
    bool isSprinting = false;

    Vector3 velocity;
    public LayerMask mask;




    void Update()
    {
        //Comprueba si el jugador esta tocando el suelo para resetear la velocidad de caida
        isGrounded = Physics.CheckSphere(groundCheck.position, sphereRadius, mask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal"); //Comprueba que las teclas A, D, Izquierda y Derecha sean pulsadas al igual que los movimientos horizontales de Joistick de un control.
        float z = Input.GetAxis("Vertical");  //Comprueba que las teclas W, S, Arriba y Abajo sean pulsadas al igual que los movimientos verticales de Joistick de un contro.


        //Comprueba si el jugador esta pulzando la tecla para correr
        
        /*
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            isSprinting = true;

        }
        else
        {
            isSprinting = false;

        }
        */
        //Mueve y controla la velocidad de movimiento del personaje.
        Vector3 move = transform.right * x + transform.forward * z;
        cController.Move(move * speed * Time.deltaTime);

        //Controla la gravedad del personaje en escalas de gravedad terrestre.
        velocity.y += gravity * Time.deltaTime;
        cController.Move(velocity * Time.deltaTime);
         /*
        if (isSprinting == true)
        {
            cController.Move(move * maxSpeed * Time.deltaTime);

        }
        else
        {
            isSprinting = false;
        }
         */
    }
}
