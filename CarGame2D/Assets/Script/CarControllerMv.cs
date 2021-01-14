using UnityEngine;
using UnityEngine.SceneManagement;

public class CarControllerMv : MonoBehaviour
{
    [Range(10f, 15f)]
    public float fCarMvSpd;
    private float fPosXLimit=2f;
    public static Vector3 v3CarPosition;
    public UIManager UIManager;
    public AudioManager AudioManager;
    // Start is called before the first frame update
    void Start()
    {
        //Get Car Position Initially
        v3CarPosition = transform.position;
        AudioManager.AudSrcCarSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Add x direction
        v3CarPosition.x += Input.GetAxis("Horizontal") * Time.deltaTime * fCarMvSpd;
        //Limit to X-Region
        v3CarPosition.x = Mathf.Clamp(v3CarPosition.x, -fPosXLimit, fPosXLimit);
        transform.position = v3CarPosition;
    }

    private void OnCollisionEnter2D(Collision2D col_info)
    {
        if(col_info.gameObject.tag=="Tg_Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //Pause the game Time.timeScale = 0;
            UIManager.GameOverActivate();
        }

    }
}
