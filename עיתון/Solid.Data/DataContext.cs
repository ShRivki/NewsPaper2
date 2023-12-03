using CsvHelper;
using Solid.Core.Entities;
using System.Globalization;

namespace Solid.Data
{
    public class DataContext
    {
        public readonly List<Designer> _Designers;
        public readonly List<Writer> _Writers;
        public readonly List<Editor> _Editors;
        public DataContext()
        {
            
            using (var reader = new StreamReader("../Solid.Data/Designers.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                _Designers = csv.GetRecords<Designer>().ToList();
            }
            using (var reader = new StreamReader("../Solid.Data/Editors.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                _Editors = csv.GetRecords<Editor>().ToList();
            }
            using (var reader = new StreamReader("../Solid.Data/Writers.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                _Writers = csv.GetRecords<Writer>().ToList();
            }
        }
    }
}
