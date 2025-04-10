using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automobile : MonoBehaviour
{
    public bool pedalGazaNaghata;//��������� ������� ����������(����� ������� ��� ������� �������)
    public Koleso[] kolesa;//������ � ������ kolesa

    void Iehati()
    {
        
        if (pedalGazaNaghata)//��� ������� ������ ����
        {
            
            foreach (var koleso in kolesa)//��� ������� ������ � �������� ������...
            {
                
                koleso.Vrachatsa();//...����������� ����� Vrachatsa

            }

        }
    }

    private void FixedUpdate()
    {
        Iehati();
    }


}
