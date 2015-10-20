using UnityEngine;
using System.Collections;

public class LockZRotation : MonoBehaviour {
	void Update () {
        transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
    }
}
