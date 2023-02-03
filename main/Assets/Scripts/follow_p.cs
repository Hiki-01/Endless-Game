using UnityEngine;

public class follow_p : MonoBehaviour
{
    public Transform follower;
    public Vector3 cam;
    // Update is called once per frame
    void Update()
    {
        transform.position = follower.position + cam;
    }
}
