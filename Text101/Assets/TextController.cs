using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;

	}

	// Update is called once per frame
	void Update () {
		print(myState);
		if (myState == States.cell)             {state_cell ();}
		else if (myState == States.sheets_0)    {state_sheets_0();}
		else if (myState == States.sheets_1)    {state_sheets_1();}
		else if (myState == States.lock_0)      {state_lock_0();}
		else if (myState == States.lock_1)      {state_lock_1();}
		else if (myState == States.mirror)      {state_mirror();}
		else if (myState == States.cell_mirror) {state_cell_mirror();}
		else if (myState == States.freedom)     {state_freedom();}
	}

	void state_cell(){
		text.text = "You are in a prison cell, and you want to escape. There are " +
			"some dirty sheets on the bed, a mirror on the wall, and the door " + "is locked from the outside.\n\n" +
			"Press S to view Sheets, M to view Mirror and L to view Lock" ;
		if(Input.GetKeyDown(KeyCode.S))         {myState = States.sheets_0;}
		else if(Input.GetKeyDown(KeyCode.M))    {myState = States.mirror;}
		else if(Input.GetKeyDown(KeyCode.L))    {myState = States.lock_0;}     
	}

	void state_sheets_1(){
		text.text = "You see the reflection of the sheets in your prison mirror, " +
			"if anything the look dirtier.\n\n" +
			"Press R to Return to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R))         {myState = States.cell;}       
	}

	void state_sheets_0(){
		text.text = "The sheets smell of hell and you feel like you might pass out if you have to stay in this cell much longer. " +
			"Clean-up better come soon, although in here that can take days, if not weeks\n\n" +
			"Press R to Return to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R))         {myState = States.cell;}
	}

	void state_lock_0(){
		text.text = "Iowa must've run out of funds for their prisons. The lock feels like an old number pad, but you can't see it. " +
			"Maybe if you could see the fingerprints...\n\n" +
			"Press R to Return to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R))         {myState = States.cell;}
	}

	void state_lock_1(){
		text.text = "The mirror is just small enough to fit through the bars. You adjust it until you're able to see the fingerprints, " +
			"they're quite clear actually. It seems like only 3 buttons are used in the code. That should be... 9 combinations.\n\n" +
			"Press O to Open the door, or R to Return to your cell";
		if(Input.GetKeyDown(KeyCode.O))         {myState = States.freedom;}
		else if(Input.GetKeyDown(KeyCode.R))    {myState = States.cell;}
	}

	void state_mirror(){
		text.text = "It seems as though the mirror could come off any second now.\n\n" +
			"Press T to Take the mirror, or R to Return to your cell";
		if(Input.GetKeyDown(KeyCode.T))         {myState = States.cell_mirror;}
		else if(Input.GetKeyDown(KeyCode.R))    {myState = States.cell;}
	}

	void state_cell_mirror(){
		text.text = "The mirror is dusty, but may be useful still. It's not quite as dirty as the sheets are, though.\n\n" +
			"Press L to view the Lock, or S to view the Sheets";
		if(Input.GetKeyDown(KeyCode.L))     {myState = States.lock_1;}
		if(Input.GetKeyDown(KeyCode.S))     {myState = States.sheets_1;}
	}

	void state_freedom(){
		text.text = "The 4th combination worked. You creek open the door, no guards. " +
			"As you walk outside and turn around, you see the combination was your cell number in reverse. " +
			"Regardless, you decide not to be delayed and run for the exit before someone finds you. You made it out, you are FREE!\n\n" +
			"Press P to play again!";
		if(Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}

	}
}