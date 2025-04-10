using System;
using UnityEngine;

public class Koleso : MonoBehaviour
{
    
    public Transform automobile;//создание поля публичной сущности с именем

    public void Vrachatsa()//это метод должен быть публичным?
    {
        automobile.position = automobile.position + Vector3.forward * 0.01f;// поле automobile вызывает "исструкцию" - position...
        transform.Rotate(10, 0, 0, Space.World);//даем указание классу Koleso вращаться по оси X в мировом пространстве
    }
}