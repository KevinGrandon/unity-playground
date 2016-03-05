using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 10;

	public Text guessText;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;

		max = max + 1;
	}

	void NextGuess () {
		guess = (max + min) / 2;
		guessText.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene ("Win");
		}
	}

	public void GuessHigher() {
		min = guess;
		NextGuess ();
	}

	public void GuessLower() {
		max = guess;
		NextGuess ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GuessHigher ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GuessLower ();
		}
	}
}
