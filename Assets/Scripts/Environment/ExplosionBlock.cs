using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Explosion))]
public class ExplosionBlock : MonoBehaviour
{
    private Explosion _explosion;
    private bool _isActivated = false;

    [Header("Particles")]
    [SerializeField] private GameObject _explosionParticle;

    [Header("Audio Effect")]
    [SerializeField] private AudioSource _explosionAudio = null;

    private bool _audioPlayed = false;

    private void Awake()
    {
        _explosion = GetComponent<Explosion>();
    }

    private void FixedUpdate()
    {
        if (_isActivated)
        {
            _explosion.Explode();
            Instantiate(_explosionParticle, transform.position, Quaternion.identity);
            
            if(!_audioPlayed)
            {
                _explosionAudio.Play();
                _audioPlayed = true;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.TryGetComponent(out Ball ball))
        {
            _explosionAudio.Play();
        }
    }

    public void SetActivate(bool isActivated)
    {
        _isActivated = isActivated;
    }
}
