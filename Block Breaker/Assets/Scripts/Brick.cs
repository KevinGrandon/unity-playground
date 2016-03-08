using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;
	private LevelManager levelMangager;

	void OnCollisionEnter2D(Collision2D collision) {
		timesHit++;
		if (timesHit >= maxHits) {
			Destroy (gameObject, 0.1f);
		}
	}

	// Use this for initialization
	void Start () {
		levelMangager = GameObject.FindObjectOfType<LevelManager> ();
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Win() {
		levelMangager.LoadNextLevel ();
	}
}
