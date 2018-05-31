using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freund : MonoBehaviour
{

	 public TextMesh counterText;

	 private int counter = 0;

	 void OnTriggerEnter2D (Collider2D other)
	 {
		  Debug.Log("FREUND freut sich!");
		  Destroy(other.gameObject);

		  counter++;
		  counterText.text = "" + counter;
	 }


}
