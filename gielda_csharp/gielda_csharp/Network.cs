using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace gielda_csharp
{
    class Network
    {
        public const int MAX_LAYERS = 3;
        
        int layers;
	    int[] size = new int[MAX_LAYERS];			// size of each layer - number of neurons
	    Neuron[][] n = new Neuron[MAX_LAYERS][];			// neurons
	    int inputs;
	    double[] inputsArr;						// array of inputs
	    int outputs;
	    double[] outputsArr;						// array of outputs
    
        Network(){
	        layers = 0;
	        inputs = 0;
	        inputsArr = null;
	        outputs = 0;
	        outputsArr = null;
        }
        
        int SaveToFile(string filename){
	        string filename2;
	        //sprintf(filename2, "%s.ann", filename);
	        filename2 = filename+".ann";

            if(!File.Exists(filename)){
                using (StreamWriter sw = File.CreateText(filename)){
                    using (StreamWriter sw2 = File.CreateText(filename2)){
                        if(outputsArr.Count() == 0) return 1;
                        
                        sw.WriteLine(layers);
                        sw.WriteLine(inputs);
                        sw.WriteLine(outputs);
                        sw2.WriteLine("layers="+layers);
                        sw2.WriteLine("inputs="+inputs);
                        sw2.WriteLine("outputs="+outputs);
                        
                        int i;
	                    for (i=0; i<layers; i++){
		                    sw.WriteLine("%d", size[i]);
		                    sw2.WriteLine("size[%d]=%d", i, size[i]);
	                    }
                        for (i = 0; i < layers; i++)
                        {
                            for (int j = 0; j < size[i]; j++)
                            {
                                sw.WriteLine("%d", n[i][j].type);
                                sw2.WriteLine("n[%d][%d].type=%d", i, j, n[i][j].type);
                                sw.WriteLine("%d", n[i][j].w);
                                sw2.WriteLine("n[%d][%d].w=%d", i, j, n[i][j].w);
                            }
                        }
                    }
                }
                return 0;
            }
            return 2;
        }
        int LoadFromFile(string filename){
            using (StreamReader sr = File.OpenText(filename))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(s);
                }
            }
            return 0;
        }




    }
}
