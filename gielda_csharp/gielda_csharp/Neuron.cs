using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gielda_csharp
{
    class Neuron
    {
        public const int TYPE_LINEAR = 0;
        public const int TYPE_BIPOLAR = 1;
        public const int TYPE_SIGNUM = 2;

        public int type;
        public int inputs;
         
        public double[] x; // inputs
        public double[] w; // weights

        public double y; // outputs

        double e() // funkcja sumujaca wejscia
        {
            double result = 0;
            for (int i = 0; i < inputs; i++)
            {
                result += x[i] * w[i];
            }
            return result;
        }
        double f(double _in) // funkcja progujaca
        {
            if (type == TYPE_LINEAR){
		        return _in;
	        }
	        else if (type == TYPE_BIPOLAR){
		        if (_in < 0) return -1;
		        else return 1;
	        }
	        else if (type == TYPE_SIGNUM){
		        if (_in < 0) return -1;
		        else if (_in == 0) return 0;
		        else return 1;
	        }
	        return 0;
        }
        Neuron()
        {
            type = TYPE_LINEAR;
            x = null;
            w = null;
            inputs = 0;
            y = 0;
        }
        Neuron(int t, int _in, double[] _x, double[] _w)
        {
            type = t;
            inputs = _in;
            x = new double[inputs];
            w = new double[inputs];
            for (int i = 0; i < inputs; i++)
            {
                x[i] = _x[i];
                w[i] = _w[i];
            }
        }
        
    }
}
