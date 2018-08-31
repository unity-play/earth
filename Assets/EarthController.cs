using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthController : MonoBehaviour
{
    public float sensitivity = 2f;

    private float circumference;

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        print(renderer.bounds.size.x);
        circumference = Mathf.PI * renderer.bounds.size.x;
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            float rotateX = sensitivity * 90f * Input.GetAxis("Mouse X") / circumference;
            float rotateY = sensitivity * 90f * Input.GetAxis("Mouse Y") / circumference;
            transform.Rotate(Vector3.up, -rotateX, Space.World);
            transform.Rotate(Vector3.right, rotateY, Space.World);
        }
    }
}
