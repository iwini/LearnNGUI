using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
	public void changeToRed(){
		GetComponent<UIWidget>().color = Color.red;
	}

	public void changeToGreen(){
		GetComponent<UIWidget>().color = Color.green;
	}

	public void changeToBlue(){
		GetComponent<UIWidget>().color = Color.blue;
	}
}
