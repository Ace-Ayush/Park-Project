using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   [SerializeField]private float _speed = 7f;
    [SerializeField]private float _mouseSensitivity = 50f;
    [SerializeField]private float _minCameraview = -70f, _maxCameraview = 80f;
    private CharacterController _charController;
    private Camera _camera;
    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();
        _camera = Camera.main;

        if(_charController == null)
        Debug.Log("No Character Controller Attached to Player");

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Get WASD Input for Player
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        //move player based on WASD Input
        Vector3 movement = transform.forward * vertical + transform.right * horizontal; //changed this line.
        _charController.Move(movement * Time.deltaTime * _speed);


        
        //Get Mouse position Input
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity; //changed this line.
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity; //changed this line.
          //Rotate the camera based on the Y input of the mouse
          xRotation -= mouseY;
          //clamp the camera rotation between 80 and -70 degrees
          xRotation = Mathf.Clamp(xRotation, _minCameraview, _maxCameraview);

          _camera.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
          //Rotate the player based on the X input of the mouse
          transform.Rotate(Vector3.up * mouseX * 3);

    }
}