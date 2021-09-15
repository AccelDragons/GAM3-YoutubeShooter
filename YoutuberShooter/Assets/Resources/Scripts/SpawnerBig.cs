using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBig : MonoBehaviour
{
    float randX;
    private Vector2 wheretoSpawn;
    public float spawnRate = 8.0f;
    public float nextSpawn = 0.0f;
    public GameObject GunEnemyPrefab;
    public float counter = 0.0f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (counter < nextSpawn)
        {
            counter += Time.deltaTime;
        }
        else
        {
            randX = Random.Range(-7.33f, 7.33f);
            wheretoSpawn = new Vector2(randX, transform.position.y);
            GameObject G = Instantiate(GunEnemyPrefab, wheretoSpawn, Quaternion.identity);
            G.GetComponent<GunEnemy>().player = player;
            counter = 0.0f;
        }
    }
};
