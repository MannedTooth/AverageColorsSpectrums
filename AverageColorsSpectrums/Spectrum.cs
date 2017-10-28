using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageColorsSpectrums
{
    class Spectrum
    {
        public string name { get; set; }
        public string[] fileNames { get; set; }
        public int numberOfFiles { get; set; }

        public Spectrum()
        {
            fileNames = new String[0] { };
            numberOfFiles = 0;
        }

        public Spectrum(string _name, String[] _fileNames)
        {
            name = _name;
            fileNames = _fileNames;
            numberOfFiles = fileNames.Count();
        }

        

    }
}
