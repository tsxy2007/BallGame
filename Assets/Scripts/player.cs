using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    private Rigidbody PlayerBody;
    public int force = 5;
    public Text ScoreText;
    private int score = 0;
    public GameObject WinText;
	// Use this for initialization
	void Start () {
        PlayerBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerBody)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            PlayerBody.AddForce( new Vector3(h, 0, v) * force);
        } 
	}

    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.collider.tag; // 获取碰撞到游戏物体的名字
        if (name.Equals("PickUp"))
        {
            Destroy(collision.collider.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string name = other.tag; // 获取碰撞到游戏物体的名字
        if (name.Equals("PickUp"))
        {
            Destroy(other.gameObject);
            score++;
            ScoreText.text = score.ToString();
            WinText.SetActive( score == 8 );
        }
    }
}
