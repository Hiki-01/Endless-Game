using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    // Update is called once per frame
    void Update()
    {
        score.text ="Score:" + player.position.z.ToString("0");
       

    }

}
