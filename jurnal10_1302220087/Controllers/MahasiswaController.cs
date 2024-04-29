using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using System.Linq.Expressions;

namespace jurnal10_1302220087.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> siswa = new List<Mahasiswa>
        {
          new Mahasiswa("henri", "1302220087", 2022, course),
          new Mahasiswa("fabian", "1302222", 2022, course)
        };
        private static List<string> course;

        private readonly ILogger<MahasiswaController> _logger;

        public MahasiswaController(ILogger<MahasiswaController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return siswa;
        }

        [HttpPost]
        
        public void post([FromBody] Mahasiswa Mahasiswa)
        {
            siswa.Add(Mahasiswa);
        }

        [HttpGet("{id}")]

        public Mahasiswa Get(int id) {
            return siswa[id];
        }

    }
}
