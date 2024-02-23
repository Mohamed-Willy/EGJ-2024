using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PMovement : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] float speed = 5f;
    [SerializeField] float camSpeed = 5f;
    float vertical, horizontal;
    Rigidbody rb;
    Transform _transform;
    int score;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        _transform = transform;
        Cursor.lockState = CursorLockMode.Locked;
        score = 0;
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
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Sharks"))
        {
            other.gameObject.SetActive(false);
            SceneHandler.ReloadScene();
        }
        if(other.gameObject.CompareTag("Food"))
        {
            other.gameObject.SetActive(false);
            score++;
            scoreText.text = ("Score: " + score);
            if (score >= 10)
            {
                Cursor.lockState = CursorLockMode.None;
                SceneHandler.NextScene();
            }
        }
    }
}
