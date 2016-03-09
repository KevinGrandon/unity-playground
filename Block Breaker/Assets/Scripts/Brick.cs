using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitSprites;

	private int timesHit;
	private LevelManager levelMangager;

	void OnCollisionEnter2D(Collision2D collision) {
		bool isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			HandleHits ();
		}
	}

	void HandleHits() {
		timesHit++;

		int maxHits = hitSprites.Length + 1;

		if (timesHit >= maxHits) {
			Destroy (gameObject, 0.1f);
		} else {
			LoadSprites ();
		}
	}

	void LoadSprites () {
		int spriteIndex = timesHit - 1;
		if (hitSprites [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = hitSprites [spriteIndex];
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
