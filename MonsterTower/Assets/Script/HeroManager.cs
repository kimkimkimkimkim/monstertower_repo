using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroManager : MonoBehaviour {

	//グローバル変数
	public float speed;


	//メンバ変数
	private float width = Screen.width;
	//private float height = Screen.height;
	private bool isRight = true;
	private Vector3 posHero; //ヒーローの座標

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		posHero = this.GetComponent<RectTransform> ().localPosition;
		Debug.Log (posHero);

		//ヒーローを移動
		if (isRight) {
			if (posHero.x < width / 2 - 4) {
				//右に移動
				this.GetComponent<RectTransform> ().localPosition = new Vector3 (posHero.x + speed, posHero.y, posHero.z);
			} else {
				//左に移動
				isRight = false;
			}
		} else {
			if (posHero.x > -1 * (width / 2) + 4) {
				//左に移動
				this.GetComponent<RectTransform> ().localPosition = new Vector3 (posHero.x - speed, posHero.y, posHero.z);
			} else {
				//右に移動
				isRight = true;
			}

		}

	}
}
