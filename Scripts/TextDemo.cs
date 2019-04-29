using BToolkit;
using UnityEngine;
using UnityEngine.UI;

public class TextDemo:MonoBehaviour
{

    public ImgText bText;
    public ImgText3D b3DText;
    public TextWriter textWriter;
    int n;

    void Start()
    {
        textWriter.SetTextWriting("It's the equivalent of inviting sex addicts to a brothel or holding an Alcoholics Anonymous (AA) meeting at the pub.",WriteFinish);
    }
    void WriteFinish()
    {
        textWriter.GetComponent<Text>().color = Color.red;
    }

    void Update()
    {
        if(Time.frameCount % 10 == 0)
        {
            if(n < 100000)
            {
                n++;
                bText.text = n + "";
                b3DText.text = n + "";
            }
        }
    }
}
