using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name) {
		Debug.Log ("LevelLoad called for " + name);
	}

	public void QuitRequest () {
		Debug.Log ("QuitRequest called");
	}

}
