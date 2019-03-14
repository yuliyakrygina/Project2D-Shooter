using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //to use Text variable. 

public class GameManager : MonoBehaviour
{
	public GameObject target;
	public Text scoreText;
	public GameObject winText;
	bool win = false;
	int score = 0;

    void Start()
    {
		InvokeRepeating("Spawn", 1f, 1f);
    }

    void Update()
	{
		if (win == true)
		{
			CancelInvoke("Spawn");
		}

		if (Input.GetMouseButtonDown(0))
		{
			GetComponent<AudioSource>().Play(); // getting audio manager from game manager
		}
    }

	void Spawn()
	{
		float RandomX = Random.Range(-7f, 7f);
		float RandomY = Random.Range(-3f, 3f);

		Vector3 RandomPosition = new Vector3(RandomX, RandomY, 0);

		Instantiate(target, RandomPosition, Quaternion.identity);

	}

	public void IncrementScore()
	{
		score++;
		print(score);

		scoreText.text = score.ToString(); //changing text of scoreText to score, making score a string. 

		if(score >= 10)
		{
			win = true;
			winText.SetActive(true);
		}


	}
}
