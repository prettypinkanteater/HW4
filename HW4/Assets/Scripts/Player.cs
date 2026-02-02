using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;

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
            _rigidbody.velocity = new Vector2(0,3.75f);
            _rigidbody.AddForce(Vector2.up * _speed * Time.deltaTime, ForceMode2D.Impulse);

        }
    }
}
