using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    Transform _transform;
    Vector3 offsit = new(0, 1, -4);
    private void Start()
    {
        _transform = transform;
    }
    // Update is called once per frame
    void Update()
    {
        _transform.position = Vector3.Lerp(_transform.position, target.position + offsit, 0.5f);
    }
}
