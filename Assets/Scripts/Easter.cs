using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easter : MonoBehaviour
{
    [SerializeField] private Transform bench; 
    private float timer = 0f; 
    private bool isTiming = false; 
    private AudioSource audioEgg;

    void Start()
    {
        audioEgg = GetComponent<AudioSource>();
        isTiming = true;
    }

    void Update()
    {
       EasterStart();
    }

    private void EasterStart()
    {
        if (isTiming)
        {
            timer += Time.deltaTime; 

            if (timer >= 0.8f) 
            {
                isTiming = false; 
                foreach (Transform child in bench)
                {
                    if (child.TryGetComponent<Rigidbody>(out var rb))
                    {
                        rb.isKinematic = false;
                        audioEgg.Play();
                    }
                }
            }
        }
    }
}
