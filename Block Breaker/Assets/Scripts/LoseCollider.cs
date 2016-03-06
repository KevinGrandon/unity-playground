using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider) {
		print("trigger.");
	}

	void OnCollisionEnter2D(Collision2D collision) {
		print("collision.");
	}
}
