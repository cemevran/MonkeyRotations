using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MonkeyScript : MonoBehaviour
{
    public Transform _banana;
    private Rigidbody2D _rb;
    [SerializeField] private float _moveSpeed = 10;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector3 newPos = transform.position + (CalculateMouseDir() * _moveSpeed * Time.deltaTime);
        transform.up = CalculateMouseDir();
        _rb.MovePosition(newPos);
        
    }

    private Vector3 CalculateMouseDir()
    {
        Vector3 BananaDir = (_banana.position - transform.position);
        return BananaDir;
    }















    public Text _victoryText;
    public Text _loseText;
    public Button _restartBtn;
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Unpause the game
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            _loseText.gameObject.SetActive(true);
            _restartBtn.gameObject.SetActive(true);
            //Pause game
            Time.timeScale = 0;
        }
        else if (collision.tag == "HugMonkey")
        {
            _victoryText.gameObject.SetActive(true);
            _restartBtn.gameObject.SetActive(true);
            //Pause game
            Time.timeScale = 0;
        }
    }
}
