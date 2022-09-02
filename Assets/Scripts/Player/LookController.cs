using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookController : MonoBehaviour
{
    public float lookSensitivity = 80f;
    float xRotation;

    public Transform player;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    { //actualiza los valores en el eje X
        float mouseX = Input.GetAxisRaw("Mouse X") * lookSensitivity * Time.deltaTime;
        player.Rotate(Vector3.up * mouseX);

        //actualiza los valores en el eje Y
        float mouseY = Input.GetAxisRaw("Mouse Y") * lookSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70, 70);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);


}

}
