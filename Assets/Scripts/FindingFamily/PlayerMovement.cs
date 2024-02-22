using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        if (moveInput > 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(0f, 1f, 0f, 1f), 0.1f);
        }
        else if (moveInput < 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(0f, -1f, 0f, 1f), 0.1f);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(0f, 0f, 0f, 1f), 0.1f);
        }
        transform.Translate(new Vector3(0, 0,Mathf.Abs(moveInput) * speed * Time.deltaTime));
        transform.position = new Vector3(transform.position.x, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            ObstacleCloner.timer = 0;
            SceneHandler.ReloadScene();
        }
    }
}
