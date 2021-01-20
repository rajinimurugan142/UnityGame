using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScnLoad : MonoBehaviour
{
    private int ScnBuildIndex;
    private Text TxtScore;
    private GameObject GOTxtScore;
    public AudioSource AudSrcGameOver;
    public AudioSource AudSrcEngStart;
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Scn_GameOver_2")
        {
            AudSrcGameOver.Play();
            GOTxtScore = GameObject.FindGameObjectWithTag("Text");
            TxtScore = GOTxtScore.GetComponent<Text>();
            TxtScore.text = "SCORE : " + UIManager.iScore;
        }
        else if (SceneManager.GetActiveScene().name == "Scn_Menu_0")
        {
            AudSrcEngStart.Play();
        }
    }
    public void LoadGameScn()
    {
        ScnBuildIndex = SceneManager.GetActiveScene().buildIndex;
        //Debug.Log(SceneManager.GetActiveScene().name + ScnBuildIndex);
        switch (ScnBuildIndex)
        {
            case 0:
                //GO TO Scn_Lvl_1
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case 1:
                //GO TO Scn_GameOver_2
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                break;
            case 2:
                //GO TO Scn_Menu_0
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
                break;
            default:
                break;
        }
    }
    public void OnClickAppExit()
    {
        Debug.Log("Application Exited");
        Application.Quit();
    }
}
