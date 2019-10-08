using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieOana.ViewModel
{
    [Serializable]
    public class SearchResult
    {
            public List<Search> Search { get; set; }
            public string totalResults { get; set; }
            public string Response { get; set; }
    }
}
