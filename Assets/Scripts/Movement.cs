using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Vector2 direction;
    private GameManager manager;

    [SerializeField] private Rigidbody player;
    [SerializeField] private float sideSpeed = 500f;

    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (transform.position.y <= -1)
        {
            manager.endConditions();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player.AddForce(direction.x * sideSpeed * Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "End")
        {
            manager.winConditions();
        }
    }

    void OnCollisionEnter(Collision collisionInfo){
        if (collisionInfo.collider.tag == "Enemy")
        {
            manager.endConditions();
        }
    }

    void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
    }
}

