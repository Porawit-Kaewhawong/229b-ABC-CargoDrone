using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.transform.position + offset;
        }
    }
}
