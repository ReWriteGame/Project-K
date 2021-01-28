using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Sprite red, blue;// создаем поля у объектов которые можно редактировать из unity

    void OnMouseDown()
    {
        GetComponent <SpriteRenderer>().sprite = red;
    }

    void OnMouseUp()// Сработает когда user заберет палец с экрана неважно где
    {
        GetComponent <SpriteRenderer>().sprite = blue;

    }
    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {



            case "Play":
                //Application.OpenURL("http://google.com");// переход по интернет ссылке
                Application.LoadLevel("Play");// загрузка уровня/локации
                break;  




        }
    }
}
