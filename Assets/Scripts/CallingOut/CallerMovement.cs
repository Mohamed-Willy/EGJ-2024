using UnityEngine;
public class CallerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float start;
    [SerializeField] float end;
    [SerializeField] float axisX;
    Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        axisX = Input.GetAxis("Horizontal");
        if (_transform.position.x > end && axisX > 0) axisX = 0;
        if (_transform.position.x < start && axisX < 0) axisX = 0;
        _transform.Translate(axisX * Time.deltaTime * speed, 0, 0);
    }
}
