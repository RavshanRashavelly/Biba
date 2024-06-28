using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitObj : MonoBehaviour
{

    private Light lightComponent; // Ссылка на компонент света, который нужно включить
    public Material emmision;


    private void OnCollisionEnter(Collision collision)
    {
        // Проверяем, есть ли у объекта, с которым произошло столкновение, компонент света
        if (collision.gameObject.GetComponent<Light>() != null)
        {
            collision.gameObject.GetComponent<MeshRenderer>().material = emmision;
            lightComponent = collision.gameObject.GetComponent<Light>();
            // Включаем компонент света
            lightComponent.enabled = true;
           
        }
    }
}
