using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class Movement : MonoBehaviour
{   
    Rigidbody2D rb2d;
    bool enter;
    bool intent;
    public int life;
    int i;
    
    public GameObject heart0;
    public GameObject heart1;
    public GameObject heart2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //gameObject.transform.position = new Vector2(0f, -2.45f);
        enter = false;
        intent = true;
        life = 3;
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) {
            rb2d.drag = 10000000;
            rb2d.angularDrag = 10000000;
            gameObject.transform.position = new Vector2(-0.05f, -2.5f);
            --life;
            if (life == 2) heart2.SendMessage("dead");
            if (life == 1) heart1.SendMessage("dead");
            if (life <= 0) {
                heart0.SendMessage("dead");
                SceneManager.LoadScene("Escena1");
            }
            enter = false;
            intent = true;
        }
        if (Input.GetKey("e")) {
            Application.Quit();
        }
        if (Input.GetKey("return") && intent) {
            rb2d.drag = 0;
            rb2d.angularDrag = 0.05f;
            enter = true;
            intent = false;
            rb2d.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
        }
        if (Input.GetKey("1") && intent) {
            gameObject.transform.position = new Vector2(-6.05f, -2.5f);
        }
        else if (Input.GetKey("2") && intent) {
            gameObject.transform.position = new Vector2(-3.05f, -2.5f);
        }
        else if (Input.GetKey("3") && intent) {
            gameObject.transform.position = new Vector2(-0.05f, -2.5f);
        }
        else if (Input.GetKey("4") && intent) {
            gameObject.transform.position = new Vector2(2.95f, -2.5f);
        }
        else if (Input.GetKey("5") && intent) {
            gameObject.transform.position = new Vector2(5.95f, -2.5f);
        }
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (enter) {
            if (col.gameObject.tag == "up")
            {
                rb2d.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
            }
            else if (col.gameObject.tag == "down")
            {
                rb2d.AddForce(Vector2.down * 10f, ForceMode2D.Impulse);
            }
            else if (col.gameObject.tag == "right")
            {
                rb2d.AddForce(Vector2.right * 10f, ForceMode2D.Impulse);
            }
            else if (col.gameObject.tag == "left")
            {
                rb2d.AddForce(Vector2.left * 10f, ForceMode2D.Impulse);
            }
            else if (col.gameObject.tag == "teleport")
            {   
                gameObject.transform.position = new Vector2(-6f, -0.5f);
                rb2d.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
            }
            else if (col.gameObject.tag == "Finish")
            {   
                Destroy(gameObject);
                intent = true;
                enter = false;
                SceneManager.LoadScene("Escena2");
            }
            else if (col.gameObject.tag == "Finish1")
            {   
                Destroy(gameObject);
                intent = true;
                enter = false;
                SceneManager.LoadScene("Escena3");
            }
        }
    }
}
