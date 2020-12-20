//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using SampleRegression.Model;

namespace SampleRegression.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // train the model from scratch
            ModelBuilder.CreateModel();

            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Hr = 0F,
                Holiday = 0F,
                Weekday = 6F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Cnt with predicted Cnt from sample data...\n\n");
            Console.WriteLine($"Hr: {sampleData.Hr}");
            Console.WriteLine($"Holiday: {sampleData.Holiday}");
            Console.WriteLine($"Weekday: {sampleData.Weekday}");
            Console.WriteLine($"\n\nPredicted Cnt: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
