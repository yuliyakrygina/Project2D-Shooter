using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	public GameObject target;

	int score = 0;

    void Start()
    {
		InvokeRepeating("Spawn", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
	{

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
	}
}
