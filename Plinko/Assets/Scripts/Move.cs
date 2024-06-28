using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;  

    private float MoveSpeeed = 5;
    private bool CanMove = true;


    private void Update()
    {
        if (CanMove == true)
        {
            Vector3 moveOffset = Vector3.zero;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
