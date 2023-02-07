using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessGround : MonoBehaviour
{
    public int MakeGround = 10;
    public GameObject Ground;
    Vector3 NextGround;
   public void GroundMaker() {
       GameObject temp= Instantiate(Ground, NextGround, Quaternion.identity);
        NextGround = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
        for (int i = 0; i < MakeGround; i++)
        {
            GroundMaker();
        }
        }

   
}