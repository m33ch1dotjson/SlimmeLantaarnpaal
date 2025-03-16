using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SlimmeLantaarnpaal
{
    class SensorWaarde
    {
        public int ID { get; set; }
        public int LantaarnpaalID { get; set; }
        public int Lichtsterkte { get; private set; }
        public bool BewegingGedetecteerd { get; set; }
        public DateTime Meetmoment { get; private set; }

        private SerialPort serialPort;


        //ChatGPT poort uitlezen

        public SensorWaarde(string poortNaam = "COM5")
        {
            serialPort = new SerialPort(poortNaam, 115200);
        }

        public int LeesLichtwaarde()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }

                string data = serialPort.ReadLine().Trim();
                if (int.TryParse(data, out int lichtSterkte))
                {
                    return lichtSterkte;
                }
            }
            catch { /* Fout negeren */ }
            finally
            {
                serialPort.Close();
            }

            return -1; // -1 als er geen geldige waarde is ontvangen
        }
    }
}

