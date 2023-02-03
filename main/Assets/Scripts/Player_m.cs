
using UnityEngine;

public class Player_m : MonoBehaviour
{
    public Rigidbody move;
    public float zforce = 2000f;
    public float xforce = 2000f;
    public float jumb = 0.1f;
  


    // Update is called once per frame
    void FixedUpdate()
    {

        move.AddForce(0,0,zforce * Time.deltaTime);
        if (Input.GetKey("d")) 
        {
            move.AddForce(xforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
 }
        if (Input.GetKey("a"))
        {
            move.AddForce(-xforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            move.AddForce(0, jumb, 0, ForceMode.Impulse);
            if(move.position.y < -1f)
            {
                jumb = 1;
            }
        }
        if (move.position.y < -1f) {
            FindObjectOfType<GameManager>().GameOver();

        }
    }
}
