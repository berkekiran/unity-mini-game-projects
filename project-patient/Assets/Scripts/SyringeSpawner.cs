using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyringeSpawner : MonoBehaviour
{
    public GameObject syringe;
    public List<GameObject> syringeIns;
    Sprite maskImage;
    int randZ;
    Color pixel;
    Vector2 touchPos;
    public Text syringeCountText;
    public int syringeCount;

    void Start()
    {
        maskImage = GameObject.FindGameObjectWithTag("Patient").GetComponent<Image>().sprite;
    }

    void Update()
    {
        syringeCountText = GameObject.FindGameObjectWithTag("SyringeCount").GetComponent<Text>();
        syringeCountText.text = syringeCount.ToString();
        touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pixel = maskImage.texture.GetPixel(Mathf.RoundToInt(touchPos.x), Mathf.RoundToInt(touchPos.y));

        randZ = Random.Range (-50, 175);

        if(Input.GetMouseButtonDown(0) && pixel == new Color(1, 1, 1, 1) && syringeCount != 0)
        {
            syringeIns.Add(Instantiate (syringe, touchPos, Quaternion.Euler(0, 0, randZ), GameObject.FindGameObjectWithTag("Canvas").transform) as GameObject);
            syringeCount = syringeCount - 1;
            syringeCountText.text = syringeCount.ToString();
        }
         
    }    
           
}
