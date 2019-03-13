using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour

{
	public GameManager gameManager;

    void Start()
    {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //

		Destroy(gameObject, 2f);
    }


    void Update()
    {
        
    }

	void OnMouseDown()
	{
		gameManager.IncrementScore();
		Destroy(gameObject);
	}
}
