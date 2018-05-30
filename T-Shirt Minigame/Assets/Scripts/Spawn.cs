using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	 public Rigidbody2D itemToSpawn;

	 // Use this for initialization
	 void Start ()
	 {
	 }

	 void spawn ()
	 {
		  
		  Instantiate(itemToSpawn, transform.position, Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), Vector3.forward));
	 }

	 private float nextActionTime = 0.0f;
	 public float secondsBetweenSpawn = 3f;

	 void Update ()
	 {
		  if ( Time.time > nextActionTime ) {
				nextActionTime += secondsBetweenSpawn;

				spawn();
		  }
	 }

}