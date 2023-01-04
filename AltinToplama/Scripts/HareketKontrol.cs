using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    public float hiz;
    public float max;
    public float min;
    public bool x;
    public bool y;
    private Rigidbody2D rg;
    public float yon=1;
    public float deger;
    float xmin,ymin;
    float xmax,ymax;
    void Start()
    {
        rg=this.gameObject.GetComponent<Rigidbody2D>();
        var post=transform.position;
        xmin=post.x+min;
        xmax=post.x+max;

        ymin=post.y+min;
        ymax=post.y+max;
    }
    void Update()
    {
        var pos=transform.position;
        if(pos.x==xmin || pos.x==xmax){ yon=yon*-1;}
        if(pos.y==ymin || pos.y==ymax){ yon=yon*-1;}  
        if (x==true)
        {
            pos.x=Mathf.Clamp(pos.x,xmin,xmax);
            rg.velocity=new Vector2(Time.deltaTime*hiz*yon,0);
        }
        deger=pos.x;
        if (y==true)
        {
            pos.y=Mathf.Clamp(pos.y,ymin,ymax);
            rg.velocity=new Vector2(0,Time.deltaTime*hiz*yon);
        }
        pos.z=0;
        this.transform.position=pos;
    }
    
}
