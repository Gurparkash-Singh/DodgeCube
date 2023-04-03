using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Vector2 direction;

    [SerializeField] private Rigidbody player;
    [SerializeField] private float sideSpeed = 500f;
    [SerializeField] private endgame fall;

    void Update()
    {
        if (transform.position.y <= -1)
        {
            fall.endConditions();
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
            Debug.Log("You Win!!!!");
        }
    }

    void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
    }
}

