using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController PC = other.GetComponent<PlayerController>();
            if(PC != null)
            {
                PC.Die();
            }
        }
    }
}
