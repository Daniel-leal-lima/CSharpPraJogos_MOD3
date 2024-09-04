using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    [SerializeField] float speed = 1;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) Translate(new Vector3(0f, 0f, CalculateRealSpeed()));
        if (Input.GetKey(KeyCode.S)) Translate(new Vector3(0f, 0f, -CalculateRealSpeed()));
        if (Input.GetKey(KeyCode.A)) Translate(new Vector3(-CalculateRealSpeed(), 0f, 0));
        if (Input.GetKey(KeyCode.D)) Translate(new Vector3(CalculateRealSpeed(), 0f, 0));
    }

    private void Translate(Vector3 translate)
    {
        transform.position += translate;
    }

    private float CalculateRealSpeed()
    {
        return speed / 100f;
    }
}
