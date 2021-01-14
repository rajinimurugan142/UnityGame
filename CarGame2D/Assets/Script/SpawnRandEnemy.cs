using UnityEngine;

public class SpawnRandEnemy : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spriteR;
    public GameObject   GOEnemyCar;
    private float fEnemyPosXLimit = 2f;
    public float delayTime = 1f;
    private float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = delayTime;
    }
    void RandomSpawnEnemyPos()
    {
        Vector3 v3EnemyCarPos = new Vector3(Random.Range(-fEnemyPosXLimit, fEnemyPosXLimit), transform.position.y, transform.position.z);
        Instantiate(GOEnemyCar, v3EnemyCarPos, transform.rotation);

        spriteR = GOEnemyCar.GetComponent<SpriteRenderer>();
        spriteR.sprite = sprites[Random.Range(0,4)];

    }
    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            RandomSpawnEnemyPos();
            Timer = delayTime;
        }

    }
}