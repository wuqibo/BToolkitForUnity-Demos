using UnityEngine;
using UnityEngine.UI;

namespace BToolkit
{
    public class ReadCsv : MonoBehaviour
    {

        public Text text;

        void Start()
        {
            CsvData csvData = new CsvData("Config");
            int count = csvData.Dictionary.Count;
            text.text = "Read Csv Result:";
            for (int i = 1; i < count; i++)
            {
                text.text += "\n" + csvData.GetDataByIndex(i, 1);
            }

            string id = "5";
            text.text += "\n\n id=" + id + " value=" + csvData.GetDataByID(id, 2);
        }
    }
}