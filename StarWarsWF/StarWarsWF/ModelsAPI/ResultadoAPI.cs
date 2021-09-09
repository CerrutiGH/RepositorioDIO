using System.Collections.Generic;

namespace StarWarsWF.ModelsAPI
{
    public class ResultadoAPI<ModelAPI>
    {
        public string Next { get; set; }
        public IReadOnlyList<ModelAPI> Results { get; set; }
    }
}
