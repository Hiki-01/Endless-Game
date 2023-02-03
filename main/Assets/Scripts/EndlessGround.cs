using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessGround : MonoBehaviour
{
    public  int V =10000;
    public GameObject Ground;
    Vector3 nextGround;
   public void GroundMaker() {
       GameObject temp= Instantiate(Ground, nextGround, Quaternion.identity);
        nextGround = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
        for (int i = 0; i < V; i++)
        {
            GroundMaker();
        }
        }

   
}
