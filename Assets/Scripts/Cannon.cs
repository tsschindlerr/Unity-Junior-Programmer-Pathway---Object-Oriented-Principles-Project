using UnityEngine;
using UnityEngine.InputSystem;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Rigidbody cannonRb;
    
    void Update()
    {
        RotateCannon(); //ABSTRACTION
    }

    private void RotateCannon()
    {
        float rotate = 0f;
        float rotationSpeed = 20f;

        if (Keyboard.current.aKey.isPressed)
            rotate = -1f;

        if (Keyboard.current.dKey.isPressed)
            rotate = 1f;

        cannonRb.AddTorque(Vector3.up * rotate * rotationSpeed * Time.deltaTime);
    }
}
