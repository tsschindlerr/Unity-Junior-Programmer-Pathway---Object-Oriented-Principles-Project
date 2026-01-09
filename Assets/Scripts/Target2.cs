using UnityEngine;

public class Target2 : Target //INHERITANCE
{
    public override void OnCollisionEnter(Collision collision) //POLYMORPHISM
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {

            {                
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

        }
    }
}
