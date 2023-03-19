using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody player;
    public float sideSpeed = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            player.AddForce(-sideSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            player.AddForce(sideSpeed * Time.deltaTime, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.tag);
    }

    void OnTriggerEnter (Collider col)
    {
        Debug.Log(col.tag);
    }
}
