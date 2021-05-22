using System.Collections.Generic;


namespace KeepQuietAndNobodyExplodes
{
    public class Bomb
    {
        public string serialNumber;

        public List<Indicator> indicators;

        public int batteries;

        public string[] ports;



        public struct Indicator
        {
            public bool lit;
            public string label;

            public Indicator(string label, bool lit = false)
            {
                this.label = label;
                this.lit = lit;
            }
        }
    }
}
