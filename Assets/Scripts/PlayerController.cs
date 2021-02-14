using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject completeLevelUI;
    public Transform playerSphere;
    public Material updateColor;

    private Rigidbody rb;
    private int count = 0; 
    private float movementX;
    private float movementY;
    public static float playerSpeed;
    private Vector3 resize = new Vector3(3,3,3);
    private int colorCheckInt;

    //Colors
    Color Red = new Color(130, 0, 0, 255);
    Color Green = new Color(0, 130, 0, 255);
    Color Blue = new Color(0, 0, 130, 255);


    // Start is called before the first frame update
    void Start()
    {
        isOversized();
        checkColor();
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    void checkColor()
    {
        colorCheckInt = PlayerPrefs.GetInt("colorIndex");
        switch (colorCheckInt)
        {
            case 0:
                Debug.Log("Red Success");
                updateColor.color = Red;
                break;
            case 1:
                Debug.Log("Green Success");
                updateColor.color = Green;
                break;
            case 2:
                Debug.Log("Blue Success");
                updateColor.color = Blue;
                break;
            default:
                break;
        }
    }

    void isOversized()
    {
        if (PlayerPrefs.GetInt("isOversizedInt") == 1)
        {
            
            playerSphere.position = new Vector3(0, 4, 0); 
            playerSphere.localScale = resize;
        }
        else
        {
            playerSphere.position = new Vector3(0, 1, 0);
            playerSphere.localScale = new Vector3(1,1,1);
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    public void CompleteLevel()
    {
        Debug.Log("Completed");
        completeLevelUI.SetActive(true);
        
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 13)
        {
            winTextObject.SetActive(true);
            //CompleteLevel();
            Debug.Log("LoadNextLevel success");
            Invoke("nextSceneFunc", 2f);
            

        }
    }

    void nextSceneFunc()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        speed = PlayerPrefs.GetFloat("PlayerSpeed", 0);
        //Debug.Log(speed);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
        
      
    }
}
