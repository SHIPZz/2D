using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    private float _delay = 0.5f;

    void Start()
    {
        Destroy(gameObject, _delay);
    }
}
