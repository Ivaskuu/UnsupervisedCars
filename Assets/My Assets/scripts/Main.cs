using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NeuralNetwork n = new NeuralNetwork(new int[] {3, 3, 2});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
