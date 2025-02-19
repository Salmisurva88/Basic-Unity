using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;

    public Camera mainCamera;
    public float mouseSensitifity = 200;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        Move();
        LookAround();
    }
    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Debug.Log(moveX + "," + moveY);

        Vector3 direction = new Vector3(moveX, 0, moveY) * speed * Time.deltaTime;

        transform.Translate(direction);
    }

    private void LookAround()
    { 
        float moveX = Input.GetAxis("Mouse X");
        float moveY = Input.GetAxis("Mouse Y");

        float yRotation = moveX * mouseSensitifity * Time.deltaTime;
        float xRotation = -moveY * mouseSensitifity * Time.deltaTime;

        xRotation = Mathf.Clamp(xRotation, -45, 45);

        transform.Rotate(Vector3.up, yRotation);
        mainCamera.transform.Rotate(Vector3.right, xRotation);
    }

}
