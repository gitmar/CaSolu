using System;
using System.Net.Http.Json;

using CxShared.Others;

using static System.Net.WebRequestMethods;

namespace CxClie.Services
{
    public class TblJsonRender
    {
        private readonly HttpClient _httpClie;

        public TblJsonRender(IHttpClientFactory htClieFactory)
        {
            _httpClie = htClieFactory.CreateClient("wApiClient"); // ✅ Use the named client
        }
        public async Task<TableSet?> rendTables()
        {
            try
            {
                var tables = await _httpClie.GetFromJsonAsync<TableSet>("tables");
                foreach (var lang in tables?.Langues ?? Enumerable.Empty<TableItem>())
                {
                    Console.WriteLine($"{lang.Elea}: {lang.Liba} ({lang.Abg})");
                }
                return tables;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error fetching tables: {ex.Message}");
                return null;
            }
        }
        //public async Task<TableSet> rendTables()
        //{
        //    var tables = await _httpClie.GetFromJsonAsync<TableSet>("tables"); // ✅ No "api/" needed
        //    foreach (var lang in tables?.Langues ?? Enumerable.Empty<Langue>())
        //    {
        //        Console.WriteLine($"{lang.Elea}: {lang.Liba} ({lang.Abg})");
        //    }
        //    return tables;
        //}
    }



    //public class TblJsonRender
    //{
    //    private readonly HttpClient _httpClie;
    //    public TblJsonRender(IHttpClientFactory htClieFactory)
    //    {
    //        _httpClie = htClieFactory.CreateClient("");
    //    }
    //    //public async Task<TableSet> rendTables()
    //    //{
    //    //    var tables = await _httpClie.GetFromJsonAsync<TableSet>("api/tables");
    //    //    // Example usage:
    //    //    foreach (var lang in tables.Langues)
    //    //    {
    //    //        Console.WriteLine($"{lang.Elea}: {lang.Liba} ({lang.Abg})");
    //    //    }
    //    //    return tables;
    //    //}

    //    public async Task<TableSet?> rendTables()
    //    {
    //        try
    //        {
    //            var tables = await _httpClie.GetFromJsonAsync<TableSet>("api/tables");
    //            foreach (var lang in tables?.Langues ?? Enumerable.Empty<TableItem>())
    //            {
    //                Console.WriteLine($"{lang.Elea}: {lang.Liba} ({lang.Abg})");
    //            }
    //            return tables;
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"❌ Error fetching tables: {ex.Message}");
    //            return null;
    //        }
    //    }
    //}
}
