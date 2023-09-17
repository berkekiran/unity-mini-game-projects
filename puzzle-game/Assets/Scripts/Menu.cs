using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{   
    public AudioSource clickAS;
    void Start()
    {
        ManagerScript.Instance.currentLevel = 0;
    }

    void Update()
    {
        
    }

    public void Play(){
        clickAS.Play();
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level_01");
    }

}
