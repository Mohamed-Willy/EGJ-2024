using UnityEngine;
public class EnemyMover : MonoBehaviour
{
    bool right;
    Transform _transform;
    void Start()
    {
        _transform = transform;
    }
    void Update()
    {
        if (right)
        {
            _transform.Translate(15 * Time.deltaTime, 0, 0);
        }
        else
        {
            _transform.Translate(-15 * Time.deltaTime, 0, 0);
        }
        if(_transform.position.x < -170)
        {
            right = false;
        }
        if(_transform.position.x > -45)
        {
            right = true;
        }
    }
}
