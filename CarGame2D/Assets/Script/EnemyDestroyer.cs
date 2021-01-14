using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{

    void Start()
    {
        //UIManager = GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col_info)
    {
        if (col_info.gameObject.tag == "Tg_Enemy")
        {
            Destroy(col_info.gameObject);

        }

    }
}
