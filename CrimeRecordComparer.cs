using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KursovaOOP.ArchiveForm;

namespace KursovaOOP
{
    public class CrimeRecordComparer : IComparer<CrimeRecord>
    {
        public int Compare(CrimeRecord x, CrimeRecord y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
}
 