using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerblue : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float jumbforce;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {


            rb.velocity = new Vector2(rb.velocity.x, jumbforce);

        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "pipe")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
