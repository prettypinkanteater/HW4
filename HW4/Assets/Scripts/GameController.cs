using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _pipePrefab;

    private float _timer = 2.1f;
    private float _pipeHeight;

    private int _points;
    

    public List<GameObject> _pipeList = new List <GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // make instance of player first before accessing method without referenece
        Locator.Instance.player.PointsChanged += UpdatePoints;
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if(_timer <= 0)
        {
            _pipeHeight = Random.Range(101.41f, 108.34f);
            SpawnPipe();
            _timer = 2.1f;
        }

        foreach(GameObject pipe in _pipeList)
        {
            pipe.transform.Translate(new Vector2(-84.92f, 0) * 0.1f * Time.deltaTime);
        }

    }

    private void SpawnPipe()
    {
        _pipeList.Add(Instantiate(_pipePrefab, new Vector2(102.52f, _pipeHeight), Quaternion.identity));
    }

    private void UpdatePoints()
    {
        _points++;
        GameObject.Find("Score").GetComponent<TextMeshProUGUI>().text = "Score: " + _points;
    }
}
