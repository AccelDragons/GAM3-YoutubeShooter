using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "EnemyBullet")
		{
			Destroy(gameObject);
			StartCoroutine(WaitForIt());
			if (SceneManager.GetSceneByName("Game 1").isLoaded)
			{
				SceneManager.LoadScene("GameOver1");
			}
			else if (SceneManager.GetSceneByName("Game 2").isLoaded)
			{
				SceneManager.LoadScene("GameOver2");
			}
			else if (SceneManager.GetSceneByName("Game 3").isLoaded)
			{
				SceneManager.LoadScene("GameOver3");
			}
		}
    }

	IEnumerator WaitForIt()
	{
		yield return new WaitForSeconds(3);
	}
}
