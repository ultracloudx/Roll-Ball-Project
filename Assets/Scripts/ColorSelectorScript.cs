using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ColorSelectorScript : MonoBehaviour
{
    //public Dropdown CDropdown;
    Renderer rend;
    Renderer rend2;

    Color Red = new Color(255, 0, 0);
    Color Green = new Color(0, 255, 0);
    Color Blue = new Color(0, 0, 255);
    public static Color ballColor;

    /*public void colorswitch()
    {
        switch (CDropdown.value)
        {
            default:
                ballColor = Red;
                break;
            case 1:
                ballColor = Red;
                break;
            case 2:
                ballColor = Green;
                break;
            case 3:
                ballColor = Blue;
                break;
        }
    }*/

}
