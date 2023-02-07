
using UnityEngine;

public class Player_m : MonoBehaviour
{
    public Rigidbody move;
    public float zforce = 2000f;
    public float xforce = 2000f;
    public float jumb ;
  


    // Update is called once per frame
    void FixedUpdate()
    {
        move.AddForce(0, 0, zforce * Time.deltaTime);

        for (float speed = 1;speed>0;speed++)
        {
            if (move.transform.position.z % 100 == 0)
            {
                move.AddForce(0, 0, zforce + 100 * Time.deltaTime);
            }
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move.AddForce(xforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
 }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.AddForce(-xforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move.AddForce(0, jumb, 0, ForceMode.Acceleration);
            
        }
        if (move.position.y < -1f) {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
