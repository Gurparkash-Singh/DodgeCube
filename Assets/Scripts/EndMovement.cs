using UnityEngine;

public class EndMovement : MonoBehaviour
{
    public Rigidbody end;
    public float forwardSpeed = 1000f;

    void FixedUpdate()
    {
        end.AddForce(0, 0, -forwardSpeed * Time.deltaTime);

        if (transform.position.z <= -2)
        {
            Destroy(gameObject);
        }
    }
}
