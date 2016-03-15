using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyPressScript : MonoBehaviour {

	public Text outputText;
	int counter = 0;
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			counter--;
			outputText.text = "Key Press 4 : " + counter;
		}
	}
}
