using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//automatyczne dodawanie charControlera przy odwoływaniu sie do fpsInput
[RequireComponent(typeof(CharacterController))]
//katalogowanie własnych skryptów
[AddComponentMenu("Control Script/FPS Input")]

public class FPSInput : MonoBehaviour
{

    public float speed = 6.0f;
    private CharacterController _charController;
    public float gravity = -9.8f;


    // Start is called before the first frame update
    void Start()
    {   
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // ruch postaci
       float deltaX = Input.GetAxis("Horizontal") * speed;
       float deltaZ = Input.GetAxis("Vertical") * speed;
       Vector3 movement = new Vector3(deltaX, 0, deltaZ);
       movement = Vector3.ClampMagnitude(movement, speed);
       movement.y = gravity;
       movement *= Time.deltaTime;
       movement = transform.TransformDirection(movement);
       _charController.Move(movement);
    
    }
}
