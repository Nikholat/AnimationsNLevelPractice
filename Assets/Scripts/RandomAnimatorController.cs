using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimatorController : MonoBehaviour
{
   private Animator _animator;
   
   void Start ()
   {
      _animator = GetComponent<Animator>();
   }

   void Update ()
   {
      int randomValue = Random.Range(0, 3);
      _animator.SetInteger("RandomAnim", randomValue);
   }
}
