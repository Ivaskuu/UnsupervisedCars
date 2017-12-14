using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
	void Start ()
	{
		NeuralNetwork nn = new NeuralNetwork(new int[] {3, 3, 2});

		// Should return an error
		nn.feedForward(new double[] {0.5, -0.2});

		// Should work
		double[] output = nn.feedForward(new double[] {0.5, 0, -0.2});

		foreach (double value in output)
		{
			Debug.Log(value);
		}
	}
}