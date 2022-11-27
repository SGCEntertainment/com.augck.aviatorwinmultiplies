using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private float speed;
    public float normalspeed;
    private Rigidbody2D rb;
    public int score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText2;

    [SerializeField] private GameObject losePanel;

    [SerializeField] private GameObject sound;
    private void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, 0);
        scoreText.text = score.ToString();
        scoreText2.text = "Current game: " + score.ToString();
    }

    public void OnLeftButton()
    {
        if (speed >= 0f)
        {
            speed -= normalspeed;
        }
    }
    public void OnRightButton()
    {
        if (speed <= 0f)
        {
            speed += normalspeed;
        }
    }
    public void OnButtonUp()
    {
        speed = 0f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Met" || other.gameObject.tag == "Planet")
        {
            losePanel.SetActive(true);
            Time.timeScale = 0f;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Sputnik")
        {
            score += 65;
            Instantiate(sound, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
