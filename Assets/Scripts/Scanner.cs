using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour {

	public GameObject ImageTarget1;
	public GameObject ImageTarget2;
	public GameObject ImageTarget3;
	private string nameTrack = "";

	void Start(){
		gameObject.SetActive (false);
	}

	public void captureTrackableName(){
		ImageTarget1.gameObject.SendMessage ("changeState",true);
		ImageTarget2.gameObject.SendMessage ("changeState",true);
		ImageTarget3.gameObject.SendMessage ("changeState",true);
	}

	private void setName(string name)
	{
		this.nameTrack = name;
	}

	public void getName()
	{
		Debug.Log("Esse é o nome: "+nameTrack);

	}
}
