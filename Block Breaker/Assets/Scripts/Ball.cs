using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private bool started = false;
	private Vector3 paddleToBallVector;
	private Rigidbody2D body;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		body = this.GetComponent<Rigidbody2D> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		print (paddleToBallVector);
	}
	
	// Update is called once per frame
	void Update () {
		// Lock the ball to the paddle at start.
		if (!started) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
		}

		// Wait for  amouse press to launch.
		if (Input.GetMouseButtonDown(0)) {
			print ("launch ball");
			started = true;
			body.velocity = new Vector2 (Random.Range(-2f, 2f), 10f);
		}
	}
}
