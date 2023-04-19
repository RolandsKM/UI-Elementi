using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarduParadisana : MonoBehaviour {

	int kadruSk = 0;



	void Start () {
		Debug.Log("Uzsākta Programa! Tu esi "+kadruSk+" kadrā");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Kadrs: " + kadruSk );
		kadruSk++;

    }
}
