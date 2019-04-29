using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {

    public Transform target;
    public Vector3 speed;

	void Update () {
        target.Translate(speed * Time.deltaTime);
	}
}
