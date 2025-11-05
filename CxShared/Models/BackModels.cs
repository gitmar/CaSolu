using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxShared.Models
{
    public class BackModel
    {
        public int Id { get; set; } = 0;
        public int Orig { get; set; } = 0;
        public int Error { get; set; } = 0;
        public string UsernameOrEmail { get; set; } = string.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Pnom { get; set; } = string.Empty;
        public int Idorg { get; set; } = 0;
        public int Custid { get; set; } = 0;
        public int Ordid {  get; set; } = 0;
        public string Oidstr { get; set; } = string.Empty;
        public int Iwurl { get; set; } = 0;
        public string? Weburl { get; set; }
        public string Xtoken { get; set; } = string.Empty;
        public DateTime Timeback { get; set; } = DateTime.Now;
        public string ErrMess { get; set; } = string.Empty;
    }
}
