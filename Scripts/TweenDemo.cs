using UnityEngine;
using System.Collections;
using BToolkit;

public class TweenDemo : MonoBehaviour {

    public RectTransform target;

    void Start() {
        target.anchoredPosition = new Vector2(-200, 0);
        target.localScale = new Vector3(2, 2, 2);
        Tween.Move(0, target, new Vector2(200, 0), 1f, false, Tween.EaseType.ExpoEaseOut, Continue1);
    }

    void Continue1() {
        Tween.Move(0, target, new Vector2(-200, 0), 2f, false, Tween.EaseType.SineEaseOut, Continue2);
    }
    void Continue2() {
        Tween.Move(0, target, new Vector2(200, 0), 1f, false, Tween.EaseType.BounceEaseOut, Continue3);
    }
    void Continue3() {
        Tween.Scale(0, target, new Vector3(10, 10, 10), 2f, Tween.EaseType.ElasticEaseOut, Continue4);
    }
    void Continue4() {
        Tween.Rotate(0, target, new Vector3(0, 0, 360), 2f, false, Tween.EaseType.BackEaseInOut, Continue6);
    }
    void Continue6() {
        Tween.Alpha(0, target, 0, 2, Tween.EaseType.ExpoEaseOut, Continue7);
    }
    void Continue7() {
        Tween.Alpha(0, target, 1, 1, Tween.EaseType.ExpoEaseOut, Continue8);
    }
    void Continue8() {
        Tween.Scale(0, target, new Vector3(2, 2, 2), 1f, Tween.EaseType.BackEaseOut);
        Tween.Move(0, target, new Vector2(-200, 0), 1f, false, Tween.EaseType.ExpoEaseOut, Continue9);
    }
    void Continue9() {
        Invoke("Continue9Delay", 1f);
    }
    void Continue9Delay() {
        Tween.Parabola(0, target, new Vector3(200, 0, 0), 100, 1f, false, 0.3f, null, Continue10);
    }
    void Continue10() {
        Invoke("Continue10Delay", 1f);
    }
    void Continue10Delay() {
        Tween.Shake(0, target, 10, 1, 1.5f, Continue11);
    }
    void Continue11() {
        Invoke("Continue11Delay", 1f);
    }
    void Continue11Delay() {
        Tween.Swing(0, target, 30, 20f, 2, true);
    }
}
