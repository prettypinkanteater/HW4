using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _pipePrefab;

    private float _timer = 3.0f;
    private float _pipeHeight;

    public List<GameObject> _pipeList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if(_timer <= 0)
        {
            // work on randomized pipe heigh
            //_pipeHeight = Random.Range(0f, );
            SpawnPipe();
            _timer = 3.0f;
        }

        foreach(GameObject pipe in _pipeList)
        {
            // pipe.transform.Translate();
        }

    }

    private void SpawnPipe()
    {
        _pipeList.Add(Instantiate(_pipePrefab, new Vector2(102.52f, _pipeHeight), Quaternion.identity));
    }
}
