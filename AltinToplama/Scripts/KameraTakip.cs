using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    private Vector2 hiz;
    public float yumusakZamanY;
    public float yumusakZamanX;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posX,posY;
        posX=Mathf.SmoothDamp(transform.position.x,player.transform.position.x,ref hiz.x, yumusakZamanX);
        posY=Mathf.SmoothDamp(transform.position.y,player.transform.position.y,ref hiz.y, yumusakZamanY);
        transform.position=new Vector3(posX,posY,transform.position.z);
    }
}
