using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    public Text text;
    public string mainLevel;
    void Start ()
    {
        text.text = "Your Final Score Was: " + ScoreHolder.score.myScore.ToString();
    }

    public void GoBack ()
    {
        SceneManager.LoadScene(mainLevel);
    }
}
