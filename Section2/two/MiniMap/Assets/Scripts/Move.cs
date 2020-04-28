using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Tooltip("Change to increase/decrease movement speed")] [SerializeField] float moveSpeed = 1f;
    [Tooltip("Change to increase/decrease jump height")] [SerializeField] float jumpHeight = 5;

    public AudioSource coinSound;
    // Start is called before the first frame update
    void Start()
    {
        coinSound = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") , 0 , 0);
        transform.position += movement * Time.deltaTime * moveSpeed;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin")) {
            coinSound.Play();
            Destroy(other.gameObject);
        }
    }

    void Jump() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
        }
    }
}
