using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    [SerializeField] private float force;
    private float boundZ = 5f;
    private float boundX = 7.5f;
    private float boundY = -2f;

    private void Start()
    {
        MoveProjectile();
    }

    private void Update()
    {
        OutOfBounds();
    }

    private void OutOfBounds()
    {
        if (transform.position.z > boundZ)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < boundY)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > boundX)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -boundX)
        {
            Destroy(gameObject);
        }
    }
    private void MoveProjectile()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);
        }
    }
    }
