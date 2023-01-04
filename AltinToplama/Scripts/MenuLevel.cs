using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuLevel : MonoBehaviour
{
  
    [SerializeField]
    public AudioSource mzk;
    void Start()
    {

    }
    public void exitGame(){
        Application.Quit();
    }

    public void startGameLevel(){
        SceneManager.LoadScene("SampleScene");
    }

    public void mzkbasla(){
        mzk.Play();
    }
    public void mzkdurdur(){
        mzk.Stop();
    }
}
