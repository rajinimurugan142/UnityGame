using System.Collections;
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
    void Start()
    {
        //Get Car Position Initially
        v3CarPosition = transform.position;
        AudioManager.AudSrcCarSound.Play();
        //Time
    }
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
        if(col_info.gameObject.tag=="Tg_Enemy" )
        {
            AudioManager.AudSrcCarSound.Stop();
            AudioManager.AudSrcExplose.Play();
            //Destroy(gameObject);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;
            //Load Nxt Scene After few seconds
            StartCoroutine(WaitForLoadNxtScn(1.5F));
            UIManager.GameOverActivate();
        }
    }
    IEnumerator WaitForLoadNxtScn(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
