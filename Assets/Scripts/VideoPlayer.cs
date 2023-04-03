using UnityEngine;

public class VideoPlayer : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + offset;
    }
}
