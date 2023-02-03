using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public Text Highscore;
    public Text Endscore;
    public Transform PlayerEndScore;
    private int highScore = 0;
    private int endscore;
    void highscore() {
        endscore = (int)PlayerEndScore.position.z;
        Endscore.text = endscore.ToString("0");
        if (highScore < endscore)
        {
            highScore = endscore;
            Highscore.text = highScore.ToString("0");
        }
    }
    }

