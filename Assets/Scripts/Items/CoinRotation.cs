﻿using UnityEngine;
using System.Collections;

public class CoinRotation : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 10, 0));
	}
}
