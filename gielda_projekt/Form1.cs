using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gielda_projekt
{
    public partial class Form1 : Form
    {
        Network network;
        string trainFilePath, testFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loops = (int)numericUpDownLoop.Value;
            var rate = (double)numericUpDownRate.Value;
            var cycle = (int)numericUpDownCycle.Value;
            var days = (int)numericUpDownDays.Value;
            var fL = comboBoxfirstLayer.SelectedIndex;
            var sL = comboBoxSecondLayer.SelectedIndex;
            var tL = comboBoxThirdLayer.SelectedIndex;
            network = new Network(loops, rate, cycle, days,fL,sL,tL);

            System.Windows.Forms.MessageBox.Show("Sieć została utworzona\nPora ją czegoś nauczyć");
            //network.initNet();
            //network.initTrening();
            //network.startTraining("ENEA.mst");

        }


        private void button2_Click(object sender, EventArgs e)
        {
            var testNum = (int)numericUpDownTestNumber.Value;
            network.testNet(testFilePath, testNum);
            System.Windows.Forms.MessageBox.Show("Test został zakończony\nRezultaty w pliku testResult.tmp");
            //double[] SampleInput = new double[] { 15d, 15.05d, 14.95d, 15d, 15d, 15.10d, 15d, 15.06d, 15d };
            //var res = network.estimate(SampleInput);
            //System.Windows.Forms.MessageBox.Show("Przewidywany kurs zamkniecia: " );
        }

        private void buttonStartTrain_Click(object sender, EventArgs e)
        {
            network.startTraining(trainFilePath);
            System.Windows.Forms.MessageBox.Show("Sieć została nauczona");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog(this) == DialogResult.OK)
            {
                //strfilename = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string fullPath = op.FileName;
                labelFilepath.Text = fullPath;
                trainFilePath = fullPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog(this) == DialogResult.OK)
            {
                //strfilename = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string fullPath = op.FileName;
                labelTestFilePath.Text = fullPath;
                testFilePath = fullPath;
            }
        }
        private static void BinarySerializeObject(object obj, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, obj);
            }
            catch (SerializationException e)
            {
                throw e;
            }
            finally
            {
                fs.Close();
            }
        }
        private static object BinaryDeSerializeObject(string filename)
        {

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream(filename, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                throw e;
            }
            finally
            {
                fs.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

            SaveFileDialog op = new SaveFileDialog();
            if (op.ShowDialog(this) == DialogResult.OK)
            {
                string fullPath = op.FileName;
                BinarySerializeObject(network, fullPath);
                System.Windows.Forms.MessageBox.Show("Sieć została zapisana do pliku");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog(this) == DialogResult.OK)
            {
                string fullPath = op.FileName;
                network = (Network)BinaryDeSerializeObject(fullPath);
                System.Windows.Forms.MessageBox.Show("Sieć została wczytana");
            }
            
        }
    }
}
