using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	void OnCollisionEnter2D(Collision2D collision)
	{
		Destroy(gameObject);
	}

	private void Start()
	{
		StartCoroutine(SelfDestruct());
	}

	IEnumerator SelfDestruct()
	{
		yield return new WaitForSeconds(2.0f);
		Destroy(gameObject);
	}
}
