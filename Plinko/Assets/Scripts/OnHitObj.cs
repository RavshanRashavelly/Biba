using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitObj : MonoBehaviour
{

    private Light lightComponent; // ������ �� ��������� �����, ������� ����� ��������
    public Material emmision;


    private void OnCollisionEnter(Collision collision)
    {
        // ���������, ���� �� � �������, � ������� ��������� ������������, ��������� �����
        if (collision.gameObject.GetComponent<Light>() != null)
        {
            collision.gameObject.GetComponent<MeshRenderer>().material = emmision;
            lightComponent = collision.gameObject.GetComponent<Light>();
            // �������� ��������� �����
            lightComponent.enabled = true;
           
        }
    }
}
