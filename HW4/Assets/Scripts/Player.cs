using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private AudioSource _flySound;

    public delegate void Point();
    public event Point PointsChanged;

    public delegate void Die();
    public event Die EndGame;

    private GameObject _upperPipe;
    private GameObject _lowerPipe;
    private GameObject _pointBox;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector2(0, 3.75f);
            _rigidbody.AddForce(Vector2.up * _speed * Time.deltaTime, ForceMode2D.Impulse);
            _flySound.Play();

        }

        _upperPipe = GameObject.Find("Upper Pipe");
        _lowerPipe = GameObject.Find("Lower Pipe");
        _pointBox = GameObject.Find("PointBox");

        if( _upperPipe != null)
        {
            Debug.Log("Found Pipe");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject == _upperPipe || _lowerPipe)
        {
            EndGame.Invoke();
            Debug.Log("bonk");
        }
        if (collision.gameObject == _pointBox)
        {
            PointsChanged.Invoke();
            Debug.Log("success");
        }

    }
}
