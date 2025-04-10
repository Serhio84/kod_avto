using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automobile : MonoBehaviour
{
    public bool pedalGazaNaghata;//публичная булевая переменная(можем ставить или убирать галочку)
    public Koleso[] kolesa;//массив с именем kolesa

    void Iehati()
    {
        
        if (pedalGazaNaghata)//при нажатой педали газа
        {
            
            foreach (var koleso in kolesa)//для каждого колеса в колекции колеса...
            {
                
                koleso.Vrachatsa();//...выполнятеся метод Vrachatsa

            }

        }
    }

    private void FixedUpdate()
    {
        Iehati();
    }


}
