using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace NFSConverter
{
    [XmlRoot(ElementName = "Perf_factor")]
    public class Perf_factor
    {
        [XmlElement(ElementName = "List")]
        public string List { get; set; }
    }

    [XmlRoot(ElementName = "Probe")]
    public class Probe
    {
        [XmlElement(ElementName = "Field")]
        public string Field { get; set; }
        [XmlElement(ElementName = "Frequencies")]
        public Frequencies Frequencies { get; set; }
        [XmlElement(ElementName = "Perf_factor")]
        public Perf_factor Perf_factor { get; set; }
    }
    [XmlRoot(ElementName = "Frequencies")]
    public class Frequencies
    {
        [XmlElement(ElementName = "Unit")]
        public string Unit { get; set; }
        [XmlElement(ElementName = "List")]
        public string List { get; set; }
    }

    [XmlRoot(ElementName = "Measurement")]
    public class Measurement
    {
        [XmlElement(ElementName = "Format")]
        public string Format { get; set; }
        [XmlElement(ElementName = "List")]
        public string List { get; set; }
    }

    [XmlRoot(ElementName = "Data")]
    public class Data
    {
        [XmlElement(ElementName = "Coordinates")]
        public string Coordinates { get; set; }
        [XmlElement(ElementName = "X0")]
        public string X0 { get; set; }
        [XmlElement(ElementName = "Xstep")]
        public string Xstep { get; set; }
        [XmlElement(ElementName = "Xmax")]
        public string Xmax { get; set; }
        [XmlElement(ElementName = "Y0")]
        public string Y0 { get; set; }
        [XmlElement(ElementName = "Ystep")]
        public string Ystep { get; set; }
        [XmlElement(ElementName = "Ymax")]
        public string Ymax { get; set; }
        [XmlElement(ElementName = "Zstep")]
        public string Zstep { get; set; }
        [XmlElement(ElementName = "Zmax")]
        public string Zmax { get; set; }
        [XmlElement(ElementName = "Z0")]
        public string Z0 { get; set; }
        [XmlElement(ElementName = "Frequencies")]
        public Frequencies Frequencies { get; set; }
        [XmlElement(ElementName = "Data_files")]
        public Frequencies Data_files { get; set; }
        [XmlElement(ElementName = "Measurement")]
        public Measurement Measurement { get; set; }
    }

    [XmlRoot(ElementName = "EmissionScan")]
    public class EmissionScan
    {
        [XmlElement(ElementName = "Nfs_ver")]
        public string Nfs_ver { get; set; }
        [XmlElement(ElementName = "Filename")]
        public string Filename { get; set; }
        [XmlElement(ElementName = "File_ver")]
        public string File_ver { get; set; }
        [XmlElement(ElementName = "Data_source")]
        public string Data_source { get; set; }
        [XmlElement(ElementName = "Date")]
        public DateTime Date { get; set; }

        [XmlElement(ElementName = "Source")]
        public string Source { get; set; }
        [XmlElement(ElementName = "Disclaimer")]
        public string Disclaimer { get; set; }
        [XmlElement(ElementName = "Copyright")]
        public string Copyright { get; set; }

        [XmlElement(ElementName = "Probe")]
        public Probe Probe { get; set; }
        [XmlElement(ElementName = "Data")]
        public Data Data { get; set; }
    }


}
