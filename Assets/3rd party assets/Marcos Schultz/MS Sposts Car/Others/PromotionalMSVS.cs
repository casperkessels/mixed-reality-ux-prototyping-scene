using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PromotionalMSVS : MonoBehaviour {

	void OnGUI(){
		GUI.skin.button.fontSize = 16;
		if (GUI.Button(new Rect((Screen.width / 2 - 200), 40, 400, 50), "Need a vehicle controller? CLICK HERE")) {
			Application.OpenURL ("https://assetstore.unity.com/packages/tools/physics/ms-vehicle-system-vehicle-controller-88035");
		}
	}
}
