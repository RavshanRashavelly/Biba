using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;  

    private float MoveSpeed = 0.009f;
    private bool CanMove = true;
    private bool CanTouch = true;
    Touch touch;
    private bool isMoved = false;

    private void Update()
    {
        if (CanMove == true)
        {
            Vector3 moveOffset = Vector3.zero;
        }

        if (Input.touchCount > 0 & CanTouch)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                   transform.position.x + touch.deltaPosition.x * MoveSpeed,
                   transform.position.y,
                   transform.position.z);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                rb.useGravity = true;
                CanTouch = false;
            }
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        // ���������, ���������� �� ������ � ������ ��������
        if (collision.gameObject)
        {
            // ���������� ����������� �������
            Vector3 direction = (transform.position - collision.contacts[0].point).normalized;
            // �������� �������� �������, ���������� ��� �� �������������� �������
            rb.velocity = direction * Mathf.Max(rb.velocity.magnitude, 10f);
        }
    }


}
