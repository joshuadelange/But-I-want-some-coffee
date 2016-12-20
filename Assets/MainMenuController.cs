using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	public void StartGame (){
		Debug.Log("LEt the game begin!!");
		Application.LoadLevel("First Scene");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
