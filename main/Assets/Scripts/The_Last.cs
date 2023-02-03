using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class The_Last : MonoBehaviour
{
    public Text ExitText;
    private float ExitTime = 3f;
    public float exittime;
    public void exit()
    {
        exittime = ExitTime;
        Invoke("Exit",ExitTime);
    }
    public void Restart()
    {
        Reset();
    }
    private void Exit()
    {
       ExitText.text= "Thanks for Playing Gaol Ball";
        SceneManager.LoadScene("Start");
    }
    private void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    

}
