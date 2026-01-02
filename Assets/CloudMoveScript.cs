using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float moveSpeed=3.5f;
    public float deadZone=-50;

    void Start()
    {

    }

    void Update()
    {
        transform.position=transform.position+(Vector3.left*moveSpeed)*Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
