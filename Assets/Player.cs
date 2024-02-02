using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // �O�i
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * 0.06f;
        }

        // ���
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * 0.06f;
        }

        // �E��]
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 1.0f, 0f);
        }

        // ����]
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -1.0f, 0f);
        }

    }
}
