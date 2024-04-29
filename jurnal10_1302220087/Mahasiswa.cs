namespace jurnal10_1302220087
{
    public class Mahasiswa
    {
        public Mahasiswa(string name, string nim, int year, List<String> course)
        {
            this.name = name;
            this.nim = nim;
            this.year = year;
            this.course = course;

        }

        public string name { get; set; }

        public string nim { get; set; }

        public int year { get; set; }

        public List<String> course { get; set; }
    }
}
