using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f ;
    SurfaceEffector2D surfaceeffector2d ;
    [SerializeField] float boostspeed = 30f ;
    [SerializeField] float basespeed = 10f ;
    Rigidbody2D rg2d ;
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        surfaceeffector2d= FindObjectOfType<SurfaceEffector2D>();
        
    }

    
    void Update()
    {
        Rotateplayer();
        respondtoboost();
    }

     void Rotateplayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rg2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rg2d.AddTorque(-torqueAmount);
        }
    }

    void respondtoboost(){
        if(Input.GetKey(KeyCode.UpArrow)){
            surfaceeffector2d.speed=boostspeed;
        }
        else{
            surfaceeffector2d.speed=basespeed;
        }
    }
}
