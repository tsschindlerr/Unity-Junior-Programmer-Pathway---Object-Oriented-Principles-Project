using UnityEngine;
using UnityEngine.InputSystem;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Rigidbody cannonRb; //ENCAPSULATION
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private GameObject cannon;
    [SerializeField] private Transform spawner;

    void Update()
    {
        RotateCannon(); //ABSTRACTION
        Fire();
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

    private void Fire()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(projectilePrefab, spawner.transform.position, spawner.transform.rotation);
        }
    }
}
