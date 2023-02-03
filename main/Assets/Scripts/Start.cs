using UnityEngine.SceneManagement;
using UnityEngine;

public class Start : MonoBehaviour
{
    public void start() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
