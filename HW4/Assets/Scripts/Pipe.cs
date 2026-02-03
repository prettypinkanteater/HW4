using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private GameObject _gameController;
    // Start is called before the first frame update
    void Start()
    {
        _gameController = GameObject.FindWithTag("GameController");
        
    }

    // Update is called once per frame
    void Update()
    {
      if(GetComponentInChildren<Transform>().position.x <= 85.25f)
        {
            _gameController.GetComponent<GameController>()._pipeList.Remove(gameObject);

            KillSelf(gameObject);
        }   
    }

    public void KillSelf(GameObject gameObject)
    {
        Destroy(gameObject);
    }
}
