using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScnLoad : MonoBehaviour
{
    private int ScnBuildIndex;
    void Start()
    {
    }
    void Update()
    {

    }
    public void LoadGameScn()
    {
        ScnBuildIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(SceneManager.GetActiveScene().name + ScnBuildIndex);
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

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
