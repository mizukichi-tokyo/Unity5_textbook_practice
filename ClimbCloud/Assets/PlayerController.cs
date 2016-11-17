﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForcwe = 30.0f;
    float maxWalkSpeed = 2.0f;
    float threshold = 0.2f;

	// Use this for initialization
	void Start () {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        // ジャンプする
        if (Input.GetMouseButtonDown(0) && this.rigid2D.velocity.y == 0) {
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        //左右移動
        int key = 0;
        if (Input.acceleration.x > this.threshold) key = 1;
        if (Input.acceleration.x < -this.threshold) key = -1;

        //プレイヤーの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //スピード制限
        if (speedx < this.maxWalkSpeed) {
            this.rigid2D.AddForce(transform.right * key * this.walkForcwe);
        }

        //動く方向に応じて反転
        if (key != 0){
            transform.localScale = new Vector3(key, 1, 1);
        }

        //画面外に出た場合は最初から
        if (transform.position.y < -10) {
            SceneManager.LoadScene("GameScene");
        }

        //プレイヤーの速度に応じてアニメの速度を変える
        if (key != 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else {
            this.animator.speed = 1.0f;
        }
    }

    //ゴールに到達
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("ゴール!");
        SceneManager.LoadScene("ClearScene");
    }
}
