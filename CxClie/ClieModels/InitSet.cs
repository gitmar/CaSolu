using CxShared.Models;
using Newtonsoft.Json;

namespace CxClie.ClieModels
{
    public partial class Customer
    {
        [JsonIgnore]
        public string CustFullName => $"{Nom} - {Pnom}";
        [JsonIgnore]
        public int Xedt1 { get; set; } = 0;
    }
}
