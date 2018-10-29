using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {

	public GameObject circlePrefab; 

	public Color[] colors;

	public static int score = 0;
	public static UnityEngine.UI.Text scoreText;
	public static string[] tags;

	private float timer = 2;
	private int index = 0;

	// Use this for initialization
	void Awake ()
	{
		scoreText = GameObject.Find("ScoreText").GetComponent<UnityEngine.UI.Text>();

		tags = new string[4]
		{
			"blue", "green", "yellow", "red"
		};

		gameObject.tag = "blue";
	}

	// Update is called once per frame
	void Update()
	{
		if ((timer -= Time.deltaTime) <= 0)
		{
			timer = 2;
			Instantiate(circlePrefab);
		}

		if (Input.GetMouseButtonDown(0))
		{
			index = (index + 1) % tags.Length;
			gameObject.tag = tags[index];
			StartCoroutine(Rotate());
		}
	}

	IEnumerator Rotate()
	{
		int x = 90;

		while(x > 0)
		{
			transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 5);
			x -= 5;
			yield return new WaitForEndOfFrame();
		}
		yield return null;
	}
}
