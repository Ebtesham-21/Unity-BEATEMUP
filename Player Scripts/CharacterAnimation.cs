using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;

    void Awake() {
        anim = GetComponent<Animator>();
    }
   public void Walk(bool move) {
    anim.SetBool(AnimationTags.Movement, move);
   }

   public void Punch_1() {
    anim.SetTrigger(AnimationTags.PUNCH_1_TRIGGER);
   }
   public void Punch_2() {
    anim.SetTrigger(AnimationTags.PUNCH_2_TRIGGER);
   }
   public void Punch_3() {
    anim.SetTrigger(AnimationTags.PUNCH_3_TRIGGER);
   }

   public void Kick_1(){
    anim.SetTrigger(AnimationTags.KICK_1_TRIGGER);
   }
   public void Kick_2(){
    anim.SetTrigger(AnimationTags.KICK_2_TRIGGER);
   }
  


}
