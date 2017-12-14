using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeuralNetwork
{
	public int[] netLayers; // The structure of the network (.length == number of layers, [i] == the number of neurons in that layer)
	public double[][] neurons; // [layer][value of the neuron]
	public double[][][] weights;

	public NeuralNetwork(int[] netLayers)
	{
		this.netLayers = netLayers;
		initNeurons();
		initWeights();
	}

	private void initNeurons()
	{
		neurons = new double[netLayers.Length][]; // Set the neurons layer length
		for (int i = 0; i < netLayers.Length; i++) // Create the neurons
		{
			neurons[i] = new double[netLayers[i]];
		}
	}

	private void initWeights()
	{
		weights = new double[netLayers.Length][][];
		for (int i = 1; i < netLayers.Length; i++)
		{
			int neuronsInPrevLayer = netLayers[i-1];
			weights[i] = new double[netLayers[i]][];

			for (int j = 0; j < netLayers[i]; j++) // Run through all the neurons in the ith layer
			{
				weights[i][j] = new double[neuronsInPrevLayer];
				for (int k = 0; k < netLayers[i]; k++) // Run through all the neurons in the (i-1)th layer
				{
					// Give random values to the weights
					weights[i][j][k] = (double)Random.Range(-1f, 1f);
				}
			}
		}
	}

	public void feedForward()
	{

	}
}