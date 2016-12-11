using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuronDotNet.Core.Backpropagation;
using NeuronDotNet.Core;
using NeuronDotNet.Core.Initializers;
using System.IO;
using System.Globalization;

namespace gielda_projekt
{
    class Network
    {
        int inputNeurons = 11;
        int hiddenNeurons = 18;
        int outputNeurons = 1;
        int daysToRead = 5; // liczba dni z ktorych uczy sie siec
        int trainingIterator = 100; // ile linijek z pliku ma byc uzyte do nauki sieci
        private double learningRate = 0.3d;
        private BackpropagationNetwork network;
        public double[] SampleInput = new double[] { 1d, 2d, 3d, 4d, 5d, 6d, 7d, 8d, 9d, 10d, 11d };
        public double[] SampleOutput = new double[] { 0.01d };
        List<double[]> ValuesList; // Lista z wartosciami kolejnych wejsc i wyjsc do nauki
        private int cycles = 100;
      //  LinearLayer inputLayer;
      //  LinearLayer hiddenLayer;
      //  LinearLayer outputLayer;
        TrainingSet trainingSet;

        double maxVal, minVal, maxVol, minVol; // max/minVal maksymalna i minimalna wartosc kursu, min/maxVol minimalna i maksymalna wartosc volumenu

        public Network(int _loopsInFile, double _learningRate, int _cycles, int _days2read,int fLayer, int sLayer, int tLayer, int _alpha = 5, int _outputNeurons = 1)
        {
            inputNeurons = (_days2read-1)*5 + 1; // liczba dni -1 * 5 bo interesuje nas 5 zmiennych dla kazdego dnia, +1 bo dla ostatniego dnia jest tylko kurs otwarcia
            outputNeurons = _outputNeurons;
            trainingIterator = _loopsInFile;
            learningRate = _learningRate;
            cycles = _cycles;
            hiddenNeurons = inputNeurons * 3 - 1;  //trainingIterator / (_alpha * (inputNeurons + outputNeurons));
            daysToRead = _days2read;
            ValuesList = new List<double[]>();
            initNet(fLayer, sLayer, tLayer);
            //startTraining(filePath);

        }

        private ActivationLayer createLayer(int layer, int neurons)
        {
            switch (layer)
            {
                case 0:
                    return new LinearLayer(neurons);

                case 1:
                    return new NeuronDotNet.Core.Backpropagation.LogarithmLayer(neurons);

                case 2:
                    return new NeuronDotNet.Core.Backpropagation.SigmoidLayer(neurons);

                case 3:
                    return new NeuronDotNet.Core.Backpropagation.SineLayer(neurons);

                case 4:
                    return new NeuronDotNet.Core.Backpropagation.TanhLayer(neurons);

                default :
                    return new LinearLayer(neurons);
            }
        }

        public void initNet(int fLayer, int sLayer, int tLayer)
        {
            ActivationLayer inputLayer = createLayer(fLayer, inputNeurons);
            ActivationLayer hiddenLayer = createLayer(sLayer, hiddenNeurons);
            ActivationLayer outputLayer = createLayer(tLayer, outputNeurons);

            //var hiddenLayer = new LinearLayer(hiddenNeurons);
            //var outputLayer = new LinearLayer(outputNeurons);
            new BackpropagationConnector(inputLayer, hiddenLayer).Initializer = new RandomFunction(0d, 0.3d);
            new BackpropagationConnector(hiddenLayer, outputLayer).Initializer = new RandomFunction(0d, 0.3d);
            network = new BackpropagationNetwork(inputLayer, outputLayer);
            network.SetLearningRate(learningRate);
            SampleInput = new double[inputNeurons + outputNeurons];
            SampleOutput = new double[outputNeurons];
        }
        public void initTrening()
        {
            trainingSet = new TrainingSet(inputNeurons, outputNeurons); // ustawiamy rozmiar wektorow wejsciowych i wyjsciowych
        }
        public void startTraining(string filepath)
        {
            initTrening();
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filepath))
                {
                    int iter = 0;
                    int index = 0;
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadLine(); // pomijamy pierwsza linijke, bo jest tam naglowek
                    String[] tmp; // zmienna do ktorej beda separowane linijki
                    String[] lineMem;
                    for (int i = 0; i < daysToRead - 1; i++) // dwa osatatnie 
                    {
                        line = sr.ReadLine();
                        tmp = line.Split(',');

                        SampleInput.SetValue(Convert.ToDouble(tmp[2], System.Globalization.CultureInfo.InvariantCulture), index++); // kurs otwarcia
                        SampleInput.SetValue(Convert.ToDouble(tmp[3], System.Globalization.CultureInfo.InvariantCulture), index++); // max
                        SampleInput.SetValue(Convert.ToDouble(tmp[4], System.Globalization.CultureInfo.InvariantCulture), index++); // min   
                        SampleInput.SetValue(Convert.ToDouble(tmp[5], System.Globalization.CultureInfo.InvariantCulture), index++); // kurs zamkniecia
                        SampleInput.SetValue(Convert.ToDouble(tmp[6], System.Globalization.CultureInfo.InvariantCulture), index++); // vol
                    }

                    while (!sr.EndOfStream && iter < trainingIterator)
                    {

                        // musimy wczytac dane z dnia pierwszego, drugiego i trzeciego. przy czym dane z trzeciego dnia beda w nastepnej iteracji danymi z dnia pierwszego

                        line = sr.ReadLine();
                        lineMem = line.Split(',');
                        SampleInput.SetValue(Convert.ToDouble(lineMem[2], System.Globalization.CultureInfo.InvariantCulture), index); // kurs otwarcia ostatniego dnia
                        SampleInput.SetValue(Convert.ToDouble(lineMem[5], System.Globalization.CultureInfo.InvariantCulture), index+1); // kurs zamkniecia ostatniego dnia jako wartosc oczekiwana na wyjsciu
                        ValuesList.Add(SampleInput);
                        SampleInput = RollValInTable(SampleInput, lineMem); // przesuwamy wartosci w tabeli aby dane z dnia drugiego byly teraz danymi dla dnia 1szego. itp

                        //SampleOutput[0] = Double.Parse(tmp[5], System.Globalization.CultureInfo.InvariantCulture) / 100;
                        // parsujemy dane wczytane z pliku do tablic wejsc / wyjsc
                        //tmp = line1st.Split(',');

                        //SampleInput[0] = Convert.ToDouble(tmp[2], System.Globalization.CultureInfo.InvariantCulture) / 100;
                        //SampleInput[1] = Double.Parse(tmp[3], System.Globalization.CultureInfo.InvariantCulture) / 100;
                        //SampleInput[2] = Double.Parse(tmp[4], System.Globalization.CultureInfo.InvariantCulture) / 100;
                        //SampleInput[3] = Double.Parse(tmp[5], System.Globalization.CultureInfo.InvariantCulture) / 100;

                        //tmp = line2nd.Split(',');
                        //SampleInput[4] = Double.Parse(tmp[2], System.Globalization.CultureInfo.InvariantCulture) / 100;
                        //SampleInput[5] = Double.Parse(tmp[3], System.Globalization.CultureInfo.InvariantCulture) / 100;
                        //SampleInput[6] = Double.Parse(tmp[4], System.Globalization.CultureInfo.InvariantCulture) / 100;
                        //SampleInput[7] = Double.Parse(tmp[5], System.Globalization.CultureInfo.InvariantCulture) / 100;

                        //tmp = line3rd.Split(',');
                        //SampleInput[8] = Double.Parse(tmp[2], System.Globalization.CultureInfo.InvariantCulture) / 100;

                        //SampleOutput[0] = Double.Parse(tmp[5], System.Globalization.CultureInfo.InvariantCulture) / 100;
                        // koniec parsowania

                        //trainingSet.Add(new TrainingSample(SampleInput, SampleOutput));

                        iter++;
                    }
                    setData2Training();
                    network.Learn(trainingSet, cycles);
                    //Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        private double[] RollValInTable(double[] tab, string[] lastLine)
        {
            double[] tmp = new double[tab.Length];
            int i = 0;
            for (i = 0; i < 5*(daysToRead - 2); i++)
            {
                tmp.SetValue(tab[i + 5], i);
            }
            tmp.SetValue(Convert.ToDouble(lastLine[2], System.Globalization.CultureInfo.InvariantCulture), i++); // kurs otwarcia
            tmp.SetValue(Convert.ToDouble(lastLine[3], System.Globalization.CultureInfo.InvariantCulture), i++); // max
            tmp.SetValue(Convert.ToDouble(lastLine[4], System.Globalization.CultureInfo.InvariantCulture), i++); // min   
            tmp.SetValue(Convert.ToDouble(lastLine[5], System.Globalization.CultureInfo.InvariantCulture), i++); // kurs zamkniecia
            tmp.SetValue(Convert.ToDouble(lastLine[6], System.Globalization.CultureInfo.InvariantCulture), i); // vol
 

            return tmp;
        }
        private void setData2Training()
        {
            double[] input, output;
            maxVal = 0d; maxVol = 0d;
            minVol = 999999d; minVal = 9999999d;
            foreach (var data in ValuesList) // najpierw szukamy wartosci min i max na liscie
            {

                for (int i = 0; i < data.Length; i++)
                {
                    if (((i+1) % 5) == 0)
                    {
                        maxVol = Math.Max(maxVol, data[i]);
                        minVol = Math.Min(minVol, data[i]);
                    }
                    else
                    {
                        maxVal = Math.Max(maxVal, data[i]);
                        minVal = Math.Min(minVal, data[i]);
                    }
                }
            }

            foreach (var data in ValuesList) // nastepnie nalezy dane przeskalowac
            {
                input = new double[data.Length - 1];
                output = new double[1];
                for (int i = 0; i < data.Length - 1; i++) // -1 bo ostatnia liczba jest wyjsciem wiec trzeba ja przeniesc do osobnej tablicy
                {
                    if (((i + 1) % 5) == 0)
                    {
                        data[i] = (data[i] - minVol) / maxVol;
                    }
                    else
                    {
                        data[i] = (data[i] - minVal) / maxVal;
                    }
                    input.SetValue(data[i], i);
                }
                data[data.Length - 1] = (data[data.Length - 1] - minVal) / maxVal;
                output.SetValue(data[data.Length - 1], 0);
                trainingSet.Add(new TrainingSample(input, output));
            }

        }
        public double[] estimate(double[] input)
        {
            return network.Run(input);
        }

        private List<double[]> scaleTestData(List<double[]> list)
        {
            List<double[]> listRet = new List<double[]>();
            double[] input;
            double max, min, maxV, minV;
            max = 0d; maxV = 0d;
            min = 999999d; minV = 9999999d;
            foreach (var data in list) // najpierw szukamy wartosci min i max na liscie
            {

                for (int i = 0; i < data.Length; i++)
                {
                    if (((i + 1) % 5) == 0)
                    {
                        maxV = Math.Max(maxV, data[i]);
                        minV = Math.Min(minV, data[i]);
                    }
                    else
                    {
                        max = Math.Max(max, data[i]);
                        min = Math.Min(min, data[i]);
                    }
                }
            }
            input = new double[4];
            input[0] = min;
            input[1] = max;
            input[2] = minV;
            input[3] = maxV;
            listRet.Add(input);
            foreach (var data in list) // nastepnie nalezy dane przeskalowac
            {
                input = new double[data.Length];
                for (int i = 0; i < data.Length; i++) // -1 bo ostatnia liczba jest wyjsciem wiec trzeba ja przeniesc do osobnej tablicy
                {
                    if (((i + 1) % 5) == 0)
                    {
                        data[i] = (data[i] - minV) / maxV;
                    }
                    else
                    {
                        data[i] = (data[i] - min) / max;
                    }
                    input.SetValue(data[i], i);
                }
                listRet.Add(input);
            }
            return listRet;
        }

        public void testNet(string file, int iteracji)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(file))
                {
                    double[] testData = new double[inputNeurons];
                    double[] result = new double[iteracji];
                    double[] expResult = new double[iteracji];
                    List<double[]> dataList = new List<double[]>();
                    int iter = 0;
                    int index = 0;
                    // Read the stream to a string, and write the string to the console.
                    String line;// = sr.ReadLine(); // pomijamy pierwsza linijke, bo jest tam naglowek
                    String[] tmp; // zmienna do ktorej beda separowane linijki
                    String[] lineMem;
                    for (int i = 0; i < daysToRead - 1; i++) // dwa osatatnie 
                    {
                        line = sr.ReadLine();
                        tmp = line.Split(',');

                        testData.SetValue(Convert.ToDouble(tmp[2], System.Globalization.CultureInfo.InvariantCulture), index++); // kurs otwarcia
                        testData.SetValue(Convert.ToDouble(tmp[3], System.Globalization.CultureInfo.InvariantCulture), index++); // max
                        testData.SetValue(Convert.ToDouble(tmp[4], System.Globalization.CultureInfo.InvariantCulture), index++); // min   
                        testData.SetValue(Convert.ToDouble(tmp[5], System.Globalization.CultureInfo.InvariantCulture), index++); // kurs zamkniecia
                        testData.SetValue(Convert.ToDouble(tmp[6], System.Globalization.CultureInfo.InvariantCulture), index++); // vol
                    }
                    while (!sr.EndOfStream && iter < iteracji)
                    {

                        // musimy wczytac dane z dnia pierwszego, drugiego i trzeciego. przy czym dane z trzeciego dnia beda w nastepnej iteracji danymi z dnia pierwszego

                        line = sr.ReadLine();
                        lineMem = line.Split(',');
                        testData.SetValue(Convert.ToDouble(lineMem[2], System.Globalization.CultureInfo.InvariantCulture), index); // kurs otwarcia ostatniego dnia
                        expResult.SetValue(Convert.ToDouble(lineMem[5], System.Globalization.CultureInfo.InvariantCulture), iter); // kurs zamkniecia ostatniego dnia jako wartosc oczekiwana na wyjsciu
                        //result.SetValue(this.estimate(testData), iter);
                        //ValuesList.Add(SampleInput);
                        dataList.Add(testData);
                        testData = RollValInTable(testData, lineMem); // przesuwamy wartosci w tabeli aby dane z dnia drugiego byly teraz danymi dla dnia 1szego. itp
                        iter++;
                    }
                    List<double[]> scaledData = scaleTestData(dataList);
                    int j = 0;
                    double min = 0d, max = 0d, minV = 0d, maxV = 0d;
                    foreach (var data in scaledData)
                    {
                        if (data.Length == 4)
                        {
                            min = data[0];
                            max = data[1];
                            minV = data[2];
                            maxV = data[3];
                        }
                        else
                        {
                            double[] res = this.estimate(data);
                            result.SetValue((res[0] * max)+min, j);
                            j++;
                        }
                    }
                    using (StreamWriter sw = new StreamWriter("testResult.tmp"))
                    {
                        sw.WriteLine("Result, Expected result, error");
                        for (int i = 0; i < result.Length; i++)
                        {
                            sw.WriteLine(result[i] + ", " + expResult[i] + ", " + Math.Abs((result[i] - expResult[i])));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
