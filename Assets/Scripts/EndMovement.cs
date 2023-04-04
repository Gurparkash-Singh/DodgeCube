using UnityEngine;

public class EndMovement : MonoBehaviour
{
    private GameManager manager;
    
    [SerializeField] private Rigidbody end;
    [SerializeField] private float forwardSpeed = 1000f;

    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    void FixedUpdate()
    {
        end.AddForce(0, 0, -forwardSpeed * Time.deltaTime);

        if (transform.position.z <= -2)
        {
            manager.endConditions();
            Destroy(gameObject);
        }
    }
}
