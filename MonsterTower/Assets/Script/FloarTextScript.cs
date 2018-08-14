using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloarTextScript : MonoBehaviour {

	//メンバ変数
	private GameObject contentTower;
	private GameObject ground;
	private int floarNum = 0;

	// Use this for initialization
	void Start () {
		contentTower = GameObject.Find ("ContentTower");
		ground = GameObject.Find ("Ground");
		while(contentTower.transform.GetChild(floarNum).gameObject != ground){
			if (contentTower.transform.GetChild (floarNum).Find ("Wall").GetChild (0).gameObject ==
			   this.gameObject) {
				this.GetComponent<Text> ().text = floarNum.ToString ();
			}
			floarNum++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
