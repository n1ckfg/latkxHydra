using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixenseShowHide : MonoBehaviour {

	public Sixense_NewController sixCtl;
	public GameObject[] target;

	void Start() {
		for (int i = 0; i < target.Length; i++) {
			target[i].SetActive (false);
		}
	}

	void Update() {
		 if (sixCtl.button2Down) {
			for (int i = 0; i < target.Length; i++) {
				target[i].SetActive(true);
			}
		} else if (sixCtl.button2Up) {
			for (int i = 0; i < target.Length; i++) {
				target[i].SetActive (false);
			}
		}
	}

}
