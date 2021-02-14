using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class optionsData : MonoBehaviour
{
    public Slider speedSlider;
    public Text valueOfSlider;
    
    public static bool OversizeBall = false;
    public static float playerSpeed = 10;

    /*public Dropdown CDropdown;
    Renderer rend;
    Renderer rend2;

    Color Red = new Color(255, 0, 0);
    Color Green = new Color(0, 255, 0);
    Color Blue = new Color(0, 0, 255);
    public static Color ballColor;*/

    private void Start()
    {
        PlayerPrefs.SetInt("colorIndex", 0);
        PlayerPrefs.SetFloat("PlayerSpeed", playerSpeed);
        PlayerPrefs.SetInt("isOversizedInt", 0);
    }

    public void sliderValueText()
    {
        valueOfSlider.text = speedSlider.value.ToString("");
        playerSpeed = speedSlider.value*10;
        Debug.Log(playerSpeed);
        PlayerPrefs.SetFloat("PlayerSpeed", playerSpeed);
    }

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

    public void SetColor(int colorIndex)
    {
        switch (colorIndex)
        {
            case 0:
                Debug.Log("Red");
                PlayerPrefs.SetInt("colorIndex", 0);
                break;
            case 1:
                Debug.Log("Green");
                PlayerPrefs.SetInt("colorIndex", 1);
                break;
            case 2:
                Debug.Log("Blue");
                PlayerPrefs.SetInt("colorIndex", 2);
                break;
            default:
                Debug.Log("Red");
                PlayerPrefs.SetInt("colorIndex", 0);
                break;
        }
    }

    public void isOversized()
    {
        bool osToggle = gameObject.GetComponent<Toggle>().isOn;
        
        if (osToggle)
        {
            //Debug.Log("On");
            OversizeBall = true;
            PlayerPrefs.SetInt("isOversizedInt", 1);
        }
        else
        {
            //Debug.Log("Off");
            OversizeBall = false;
            PlayerPrefs.SetInt("isOversizedInt", 0);
        }

        if (OversizeBall)
        {
            Debug.Log("variable is true");
        }
        if (!OversizeBall)
        {
            Debug.Log("variable is false");
        }

        //Debug.Log("Working");
    }

    

    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
