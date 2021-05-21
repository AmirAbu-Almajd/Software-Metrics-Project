using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Metrics_Project
{

    class values
    {
        public static Dictionary<String, int> factorScale = new Dictionary<string, int>();
        public static Dictionary<string, Dictionary<String, int>> valuesDict = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<String, int> helperDict = new Dictionary<String, int>();
        //In this class we should hardcode the values of the (Factors' ratings , FP complixities) 
        //in flexible objects (Like a dictionary) so that we can calculate the (UFP , TCF , LOC)
        public void add_UFP_Values()
        {
            helperDict = new Dictionary<String, int>();
            helperDict.Add("Simple", 3);
            helperDict.Add("Average", 4);
            helperDict.Add("Complex", 6);
            valuesDict.Add("External Input", helperDict);
            helperDict = new Dictionary<String, int>();
            helperDict.Add("Simple", 4);
            helperDict.Add("Average", 5);
            helperDict.Add("Complex", 7);
            valuesDict.Add("External Output", helperDict);
            helperDict = new Dictionary<String, int>();
            helperDict.Add("Simple", 3);
            helperDict.Add("Average", 4);
            helperDict.Add("Complex", 6);
            valuesDict.Add("External Inquiry", helperDict);
            helperDict = new Dictionary<String, int>();
            helperDict.Add("Simple", 7);
            helperDict.Add("Average", 10);
            helperDict.Add("Complex", 15);
            valuesDict.Add("Internal Logical Files", helperDict);
            helperDict = new Dictionary<String, int>();
            helperDict.Add("Simple", 5);
            helperDict.Add("Average", 7);
            helperDict.Add("Complex", 10);
            valuesDict.Add("External Interface Files", helperDict);
        }

        public void Add_TCF_values()
        {
            factorScale = new Dictionary<string, int>();
            factorScale.Add("No Influence", 0);
            factorScale.Add("Incidental", 1);
            factorScale.Add("Moderate", 2);
            factorScale.Add("Average", 3);
            factorScale.Add("Significant", 4);
            factorScale.Add("Essential", 5);

        }
    }
}
