using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	public AudioClip boing;

	void OnCollisionEnter2D(Collision2D collision) {
		AudioSource.PlayClipAtPoint (boing, transform.position);
	}
}
