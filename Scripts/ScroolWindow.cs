using UnityEngine;
using System.Collections;
using BToolkit;

public class ScroolWindow : MonoBehaviour {

    public Object itemPrefab;
    public Scroll bScroll1, bScroll2, bScroll3;

    void Start() {
        //bScroll 1
        Transform[] items1 = new Transform[20];
        for (int i = 0; i < items1.Length; i++) {
            items1[i] = (Instantiate(itemPrefab) as GameObject).transform;
            items1[i].GetComponent<ScrollItem>().SetInfo(i);
        }
        bScroll1.SetPos(items1, Vector3.one);

        //bScroll 2
        //Pay attention to several numerical values:30=5X2X3
        Transform[] items2 = new Transform[30];
        for (int i = 0; i < items2.Length; i++) {
            items2[i] = (Instantiate(itemPrefab) as GameObject).transform;
            items2[i].GetComponent<ScrollItem>().SetInfo(i);
        }
        bScroll2.colCount = 5;
        bScroll2.rowCount = 2;
        bScroll2.pageCount = 3;
        bScroll2.SetPos(items2, Vector3.one);

        //bScroll 3
        Transform[] items3 = new Transform[30];
        for (int i = 0; i < items3.Length; i++) {
            items3[i] = (Instantiate(itemPrefab) as GameObject).transform;
            items3[i].GetComponent<ScrollItem>().SetInfo(i);
        }
        bScroll3.colCount = 3;
        bScroll3.SetPos(items3, new Vector3(0.75f, 0.75f, 0.75f));
    }

}
