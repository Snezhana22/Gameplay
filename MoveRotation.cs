using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotation : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotateSpeed = 100f;
    public float gravity = -9.8f;

    private CharacterController _charController;

    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Движение вперед/назад (WS - Vertical)
        float dz = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // Вращение влево/вправо (AD - Horizontal)
        float rotation = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, rotation, 0);

        Vector3 movement = new Vector3(0, gravity, dz);
        movement = Vector3.ClampMagnitude(movement, moveSpeed);

        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
    }
}
