using System;
using Microsoft.ML;
using Microsoft.ML.Data;
using ML;

namespace ML
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Checker();
			}
		}

		#region метод для проверки отзыва
		static void Checker()
		{
			Console.Clear();
			Console.Write("Напишите отзыв(На английском): ");
			var otziv = Console.ReadLine();

			var inputData = new ML.MLModel1.ModelInput
			{
				Col0 = otziv,
			};

			ML.MLModel1.ModelOutput output = ML.MLModel1.Predict(inputData);

			if(output.PredictedLabel == 1)
			{
				Console.WriteLine($"Predicted sentiment: Positive || Text: {otziv}");
			}
			else
			{
				Console.WriteLine($"Predicted sentiment: Negative || Text: {otziv}");
			}

			Console.WriteLine("Нажмите Enter для продолжения...");
			Console.ReadLine();
		}
		#endregion
	}
}
