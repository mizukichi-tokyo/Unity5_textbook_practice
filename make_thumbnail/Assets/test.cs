using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    //サムネイルを作成するオブジェクト
    public GameObject TargetObject;

	// Use this for initialization
	void Start () {
        //サムネイル作成
        functions.makeThumbnailPng_from_Gameobject(TargetObject, "c:/temp/temp1.png", 300, 300);
    }
	
}
