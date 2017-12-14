using UnityEngine;

public class NeuralNetwork
{
	public const double BIAS = 0.25;

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
			weights[i] = new double[netLayers[i]][];

			for (int j = 0; j < netLayers[i]; j++) // Run through all the neurons in the ith layer
			{
				weights[i][j] = new double[netLayers[i-1]];
				for (int k = 0; k < netLayers[i-1]; k++) // Run through all the neurons in the (i-1)th layer
				{
					// Give random values to the weights
					weights[i][j][k] = (double)UnityEngine.Random.Range(-1f, 1f);
				}
			}
		}
	}

	public double[] feedForward(double[] inputs)
	{
		if(inputs.Length != netLayers[0])
		{
			Debug.LogError("Neural network input neurons and input values length don't match");
			return null;
		}

		neurons[0] = inputs; // Pass the input values to the nn first (input) layer
		for (int i = 1; i < netLayers.Length; i++) // Run through all layers (except the input/first one)
		{
			for (int j = 0; j < netLayers[i]; j++) // Run through all the neurons in the ith layer
			{
				double neuronValue = BIAS;

				for (int k = 0; k < netLayers[i-1]; k++) // Run through all the neurons in the (i-1)th layer
				{
					neuronValue += weights[i][j][k] * neurons[i-1][k]; // Multiply the weight value to the value of the previous neuron
				}

				neurons[i][j] = activate(neuronValue);
			}
		}

		return neurons[neurons.Length-1];
	}

	private double activate(double value)
	{
		// TODO: Consider using ReLU
		return System.Math.Tanh(value);
	}
}