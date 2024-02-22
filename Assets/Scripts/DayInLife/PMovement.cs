using UnityEngine;

public class PMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float camSpeed = 5f;
    float vertical, horizontal;
    Rigidbody rb;
    Transform _transform;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        _transform = transform;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float h = camSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
        vertical = Input.GetAxis("Vertical") * speed;
        horizontal = Input.GetAxis("Horizontal") * speed;
        if(vertical < 0) vertical = 0;
        _transform.Rotate(0, h, 0);
    }
    private void FixedUpdate()
    {
        rb.velocity = _transform.forward * vertical;
        rb.velocity += _transform.right * horizontal;
    }
}
