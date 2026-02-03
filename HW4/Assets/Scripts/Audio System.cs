using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    [SerializeField] private AudioSource _death;
    [SerializeField] private AudioSource _point;
    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.Player.EndGame += PlayPointSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayDeathSound()
    {
        _death.Play();
    }

     void PlayPointSound()
    {
        _point.Play();
    }
}
