using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody enemy;
    public float forwardSpeed = 1000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        enemy.AddForce(0, 0, -forwardSpeed * Time.deltaTime);
        if (transform.position.z < -2)
        {
            Destroy(gameObject);
        }
    }
}
