namespace AdventOfCodeLib
{
    public class TestAnswerContainer : Dictionary<string, string>
    {
        public string Get(int day, string abc)
        {
            return this[$"{day}{abc}"];
        }

        public TestAnswerContainer()
        {
            this["1a"] = "24000";
            this["1b"] = "45000";
            this["2a"] = "15";
            this["2b"] = "12";
            this["3a"] = "157";
            this["3b"] = "70";            
            this["4a"] = "2";
            this["4b"] = "4";
            this["5a"] = "CMZ";
            this["5b"] = "MCD";
            this["6a"] = "7";
            this["6b"] = "";
        }
    }
}
