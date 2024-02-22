using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMovement : MonoBehaviour
{
    public float speed = 5f;
    float horizontal, vertical;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(horizontal, 0,vertical);
    }
}
