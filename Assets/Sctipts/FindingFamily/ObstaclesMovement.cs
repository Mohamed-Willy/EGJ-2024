using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{
    public float speed = -5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0,  speed * Time.deltaTime));
    }
}
