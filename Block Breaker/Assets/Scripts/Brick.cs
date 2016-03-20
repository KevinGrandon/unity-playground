using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitSprites;

	public static int breakableCount = 0;

	private int timesHit;
	private LevelManager levelMangager;
	private bool isBreakable;

	public AudioClip crack;
	public AudioClip boing;

	void OnCollisionEnter2D(Collision2D collision) {
		AudioSource.PlayClipAtPoint (crack, transform.position, 0.25f);
		AudioSource.PlayClipAtPoint (boing, transform.position, 0.25f);
		if (isBreakable) {
			HandleHits ();
		}
	}

	void HandleHits() {
		timesHit++;

		int maxHits = hitSprites.Length + 1;

		if (timesHit >= maxHits) {
			breakableCount--;
			levelMangager.BrickDestroyed ();
			Destroy (gameObject, 0.1f);
		} else {
			LoadSprites ();
		}
	}

	void LoadSprites () {
		int spriteIndex = timesHit - 1;
		if (hitSprites [spriteIndex] != null) {
			this.GetComponent<SpriteRenderer> ().sprite = hitSprites [spriteIndex];
		} else {
			Debug.LogError ("Brick sprite missing.");
		}
	}

	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			breakableCount++;
		}
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
