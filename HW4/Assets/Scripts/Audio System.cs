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
        Locator.Instance.Player.EndGame += PlayDeathSound;
        Locator.Instance.Player.PointsChanged += PlayPointSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayDeathSound()
    {
        _death.Play();
    }

    private void PlayPointSound()
    {
        _point.Play();
    }
}
