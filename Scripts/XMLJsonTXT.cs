using UnityEngine;
using System.Collections;
using BToolkit;
using UnityEngine.UI;

public class XMLJsonTXT : MonoBehaviour {

    public InputField label1, label2;
    public Text pathText, resultText;

    public struct DataStruct {
        public string label1;
        public string label2;
    }

    public void SaveXML() {
        DataStruct data;
        data.label1 = label1.text;
        data.label2 = label2.text;
        XMLUtils.Write<DataStruct>(Application.persistentDataPath + "/jsonData.xml", data);
        pathText.text = "save to:" + Application.persistentDataPath + "/jsonData.xml finished";
    }

    public void SaveJson() {
        DataStruct data;
        data.label1 = label1.text;
        data.label2 = label2.text;
        JsonUtils.Write(Application.persistentDataPath + "/jsonData.json", data, false);
        pathText.text = "save to:" + Application.persistentDataPath + "/jsonData.json finished";
    }

    public void SaveTxt() {
        string str = "label1=" + label1.text + " label2=" + label2.text;
        TxtUtils.Write(Application.persistentDataPath + "/jsonData.txt", str, false);
        pathText.text = "save to:" + Application.persistentDataPath + "/jsonData.txt finished";
    }

    public void ReadXML() {
        DataStruct data = XMLUtils.Read<DataStruct>(Application.persistentDataPath + "/jsonData.xml");
        resultText.text = "Read XML Result: label1=" + data.label1 + " label2=" + data.label2;
    }

    public void ReadJson() {
        DataStruct data = JsonUtils.Read<DataStruct>(Application.persistentDataPath + "/jsonData.json", false);
        resultText.text = "Read Json Result: label1=" + data.label1 + " label2=" + data.label2;
    }

    public void ReadTxt() {
        string data = TxtUtils.Read(Application.persistentDataPath + "/jsonData.txt", false);
        resultText.text = "Read Txt Result: " + data;
    }

}
