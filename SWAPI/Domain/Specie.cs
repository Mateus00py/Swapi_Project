namespace SWAPI.Domain
{
    public class Specie
    {
        public string Name { get; set; }
        public string Classification { get; set; }
        public string Designation { get; set; }
        public string AverageHeight { get; set; }
        public string SkinColors { get; set; }
        public string HairColors { get; set; }
        public string EyeColors { get; set; }
        public string AverageLifespan { get; set; }
        public string Homeworld { get; set; }
        public string Language { get; set; }
        public List<string> People { get; set; }
        public List<string> Films { get; set; }
        public string Url { get; set; }
    }
    public class Specielist
    {
        public List<Specie> Results { get; set; }
    }
}
