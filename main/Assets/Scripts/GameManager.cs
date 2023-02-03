using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool Game_over=false;
    public GameObject ExitPlane;
        public void GameOver()
    {
        ExitPlane.SetActive (false);
        if (Game_over == false)
        {
            Game_over = true;
            ExitPlane.SetActive(true);
        }
    }
}
