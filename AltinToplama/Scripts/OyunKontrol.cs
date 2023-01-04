using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject [] efect2;
    public GameObject [] efect;
    public AudioClip [] audio;
    public GameObject skor;
    public int hak=2;
    void Start()
    {
        
    }

    // Update is called once per frame
void Update()
    {
        switch(hesaplamalar.canGoster()){
            case 1:
            hak1.SetActive(true);
            hak2.SetActive(false);
            break;
            case 0:
            Time.timeScale=0;
            hesaplamalar.canFulle();
            break;
        }
    }

    public GameObject hak1,hak2;
      void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag=="altin")
        {
            hesaplamalar.PuanArttir();
            Instantiate(efect2[0],coll.transform.position,Quaternion.identity);
            Destroy(coll.gameObject);
            skor.GetComponent<TextMeshProUGUI>().text="Skor: "+hesaplamalar.puanGoster().ToString();
        }
        if (coll.gameObject.tag=="bomba"){
            Destroy(coll.gameObject);
            Instantiate(efect[0],coll.transform.position,Quaternion.identity);
            AudioSource.PlayClipAtPoint(audio[0],coll.transform.position);
            Instantiate(efect[0],coll.transform.position,Quaternion.identity);
            hesaplamalar.canAzalt();
            hak--;

            if(hak==0){
                SceneManager.LoadScene("MenuLevel");
            }
        }
        if (coll.gameObject.tag=="finish"){
            if (hesaplamalar.puanGoster()>=hesaplamalar.istenilenPuann()){
                Destroy(coll.gameObject);
                Time.timeScale=0;
                SceneManager.LoadScene("MenuLevel");
            }
        }
    }

    
}
