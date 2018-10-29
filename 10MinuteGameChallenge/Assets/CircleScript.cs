using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour {

	public Color[] colors;

	void Start ()
	{
		int rnd = Random.Range(0, Square.tags.Length);
		gameObject.tag = Square.tags[rnd];
		GetComponent<SpriteRenderer>().color = colors[rnd];
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag.Equals(gameObject.tag))
		{
			Square.score++;
			Square.scoreText.text = Square.score + "";
			Destroy(this.gameObject);
		}
		else
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(0);
		}
	}
}
