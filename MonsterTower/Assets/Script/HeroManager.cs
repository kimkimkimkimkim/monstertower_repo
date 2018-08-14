using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroManager : MonoBehaviour {

	//グローバル変数
	public float speed;


	//メンバ変数
	//private float width = (float)Screen.width;
	//private float height = Screen.height;
	private float width;
	private bool isRight = true;
	private Vector3 posHero; //ヒーローの座標
	private GameObject canvas;

	// Use this for initialization
	void Start () {
		canvas = GameObject.Find ("Canvas");
		width = canvas.GetComponent<RectTransform> ().sizeDelta.x;
	}

	// Update is called once per frame
	void Update () {
		posHero = this.GetComponent<RectTransform> ().localPosition;

		//ヒーローを移動
		if (isRight) {
			if (posHero.x < width/2 - 100) {
				//右に移動
				this.GetComponent<RectTransform> ().localPosition = new Vector3 (posHero.x + speed, posHero.y, posHero.z);
			} else {
				//左を向く
				isRight = false;
				transform.rotation = Quaternion.Euler(0, 180, 0);
			}
		} else {
			if (posHero.x > -1 * (width/2) + 100) {
				//左に移動
				this.GetComponent<RectTransform> ().localPosition = new Vector3 (posHero.x - speed, posHero.y, posHero.z);
			} else {
				//右を向く
				isRight = true;
				transform.rotation = Quaternion.Euler(0, 0, 0);
			}

		}

	}

}
