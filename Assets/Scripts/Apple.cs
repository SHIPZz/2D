using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] private SoundEffect _soundEffect;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.TryGetComponent(out PlayerAnimation playerAnimation))
        {
            Instantiate(_soundEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
