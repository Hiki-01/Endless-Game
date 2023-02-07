using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool Game_over=false;
    public GameObject ExitPlane;
    public GameObject scoreactive;
    public float RestartTime = 3f;

    public void GameOver()
    {
       
        ExitPlane.SetActive(false);
        if (Game_over == false)
        {
            Game_over = true;
            ExitPlane.SetActive(true);
            scoreactive.SetActive(false);
            Invoke("Restart", RestartTime);
        }
    }
       
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    public void Exit()
    {
        Debug.Log("nice to meet You");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
