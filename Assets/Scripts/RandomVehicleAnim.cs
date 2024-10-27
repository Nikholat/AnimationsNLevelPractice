using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomVehicleAnim : MonoBehaviour
{
   private Animator _animator;
   
   void Start ()
   {
      _animator = GetComponent<Animator>();
   }

   void Update ()
   {
      int randomValue = Random.Range(0, 2);
      _animator.SetInteger("RandomAnim", randomValue);
   }
}
