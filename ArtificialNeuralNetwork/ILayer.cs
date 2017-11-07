﻿using System.Collections.Generic;
using System.Linq;

namespace ArtificialNeuralNetwork
{
	internal interface ILayer
	{
		IEnumerable<INeuron> Neurons { get; }

		void Run();
	}
}