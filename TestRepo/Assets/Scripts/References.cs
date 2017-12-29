using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class References : MonoBehaviour {
	public static References instance;

	void Awake () {
		instance = this;
	}

	public GameObject testestes;
}
