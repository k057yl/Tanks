using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float speedRotation;
    Rigidbody rb;
    Vector3 move;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float sideForce = Input.GetAxisRaw("Horizontal") * speedRotation;
        float forwardForce = Input.GetAxisRaw("Vertical") * speed;
        rb.AddRelativeForce(0f, 0f, forwardForce);
        rb.AddRelativeTorque(0f, sideForce, 0f);
    }
}
