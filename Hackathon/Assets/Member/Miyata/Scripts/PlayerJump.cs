using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rbody2D;

    public Text gameOverText;  //ゲームオーバー表示用テキスト

    [SerializeField]
    private float jumpForce = 0f;

    private int jumpCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& this.jumpCount < 1)
        {
            jumpCount++;
            this.rbody2D.AddForce(transform.up * jumpForce);
        }
    }

    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "GameOver")
        {
            gameOverText.text = "GameOver"; //消しても大丈夫です。
            //SceneManager.LoadScene("シーン名");
        }
    }
}