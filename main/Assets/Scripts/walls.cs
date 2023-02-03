using UnityEngine;

public class walls : MonoBehaviour
{
    public Player_m death;
     void OnCollisionEnter(Collision wallsInfo)
    {
     if(wallsInfo.collider.tag == "Walls")
        {
            death.enabled= false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
