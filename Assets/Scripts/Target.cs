using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Target : MonoBehaviour
{
    [SerializeField] private Material target1ColorNew;
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    public virtual void OnCollisionEnter(Collision collision) //POLYMORPHISM
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            
            {
                rend.material = target1ColorNew;
                Destroy(collision.gameObject);
            }
            
        }
    }
}
