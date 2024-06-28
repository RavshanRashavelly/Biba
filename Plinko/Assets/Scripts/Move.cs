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
        // Проверяем, столкнулся ли объект с другим объектом
        if (collision.gameObject)
        {
            // Определяем направление отскока
            Vector3 direction = (transform.position - collision.contacts[0].point).normalized;
            // Изменяем скорость объекта, отталкивая его от столкнувшегося объекта
            rb.velocity = direction * Mathf.Max(rb.velocity.magnitude, 10f);
        }
    }


}
