using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusSpawner : MonoBehaviour
{
    
    public GameObject virus;
    public List<GameObject> virusIns;
    int randX, randY;
    Sprite maskImage;
    Color pixel;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    void Start()
    {
        maskImage = GameObject.FindGameObjectWithTag("Patient").GetComponent<Image>().sprite;
    }

    void Update()
    {
        
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            randX = Random.Range (-540, 1080);
            randY = Random.Range (-960, 1920);
            pixel = maskImage.texture.GetPixel(randX, randY);

            if(pixel == new Color(1, 1, 1, 1) && virusIns.Count < 100)
                virusIns.Add(Instantiate (virus, new Vector3(randX, randY, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform) as GameObject);
        }

    }

}
