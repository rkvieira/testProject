﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {
	public static EventManager instance;
	void Awake () {
		instance = this;
	}

	public UnityEngine.Events.UnityEvent testest;

}
