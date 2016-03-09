using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name) {
		Debug.Log ("LevelLoad called for " + name);
		SceneManager.LoadScene (name);
	}

	public void QuitRequest () {
		Debug.Log ("QuitRequest called");
		Application.Quit ();
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void BrickDestroyed() {
		// If the last brick is destroyed, 
		if (Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}
}
