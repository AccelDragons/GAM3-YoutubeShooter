using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	float randX;
	private Vector2 wheretoSpawn;
	public float spawnRate = 2.0f;
	public float nextSpawn = 0.0f;
	public GameObject EnemyPrefab;
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
			wheretoSpawn = new Vector3(randX, transform.position.y, transform.position.x);
			GameObject G = Instantiate(EnemyPrefab, wheretoSpawn, Quaternion.identity);
			G.GetComponent<Enemy>().player = player;
			counter = 0.0f;
		}
	}
};