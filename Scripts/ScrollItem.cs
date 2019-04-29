using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollItem : MonoBehaviour {

    public Text text;

    public void SetInfo(int index) {
        text.text = index + "";
    }

}
