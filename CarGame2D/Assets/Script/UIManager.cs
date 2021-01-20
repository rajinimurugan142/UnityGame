using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text TxtScore;
    public static int iScore;
    private bool BoolGameOver;
    public AudioSource audioSource;

    void Start()
    {
        iScore = 0;
        TxtScore.text = "SCORE : " + iScore;
        BoolGameOver = false;
        InvokeRepeating("ScoreUpdate", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        TxtScore.text = "SCORE : " + iScore;
    }
    public void ScoreUpdate()
    {
        if (BoolGameOver == false)
        {
            iScore += 1;
        }
    }
    public void GameOverActivate()
    {
        BoolGameOver = true;
    }
    public void PauseGame()
    {
        if(Time.timeScale==1)
        {
            Time.timeScale = 0;
            audioSource.Pause();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            audioSource.Play();
        }
    }
  
}
