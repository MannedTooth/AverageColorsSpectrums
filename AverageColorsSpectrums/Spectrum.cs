using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageColorsSpectrums
{
    class Spectrum
    {
        public String name { get; set; }
        public String[] fileNames { get; set; }
        public int numberOfFiles { get; set; }

        public Spectrum()
        {

        }

        public Spectrum(string _name, String[] _fileNames)
        {
            name = _name;
            fileNames = _fileNames;
            numberOfFiles = fileNames.Count();
        }

        

    }
}
