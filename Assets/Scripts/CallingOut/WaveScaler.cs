using System.Collections;
using UnityEngine;
public class WaveScaler : MonoBehaviour
{
    [SerializeField] Transform startPos;
    Transform _transform;
    Coroutine cur;
    private void OnEnable()
    {
        if (_transform == null)
            _transform = GetComponent<Transform>();
        _transform.localPosition = new(x: startPos.position.x + 9, 5f, 0);
        cur = StartCoroutine(Scaling());
    }
    private void OnDisable()
    {
        _transform.localScale = new(0.3f, 0.3f, 0.3f);
        StopCoroutine(cur);
    }
    IEnumerator Scaling()
    {
        while(true)
        {
            _transform.localScale = new(_transform.localScale.x, _transform.localScale.y + Time.deltaTime, _transform.localScale.z);
            _transform.Translate(0, 30 * Time.deltaTime, 0);
            yield return null;
        }
    }
}
