using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public GameObject textDisplay;
	public int secondsLeft = 30;
	public bool countdown = false;

    // Start is called before the first frame update
    void Start()
    {
		textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
	}

    // Update is called once per frame
    void Update()
    {
		if (countdown == false && secondsLeft > 0)
		{
			StartCoroutine(TimerCountdown());
		}
	}

	IEnumerator TimerCountdown()
	{
		countdown = true;
		yield return new WaitForSeconds(1);
		secondsLeft -= 1;
		if (secondsLeft > 10)
		{
			textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
		}
		else
		{
			textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
		}
		countdown = false;

		if (secondsLeft == 0)
		{
			yield return new WaitForSeconds(1);
			SceneManager.LoadScene("GameWin");
		}
	}
}
