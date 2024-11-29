using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private CharacterAnimation player_Anim;
   void Awake() {
    player_Anim = GetComponentInChildren<CharacterAnimation>();
   }

    // Update is called once per frame
    void Update()
    {
        ComboAttacks();
    }

    void ComboAttacks() {
        if(Input.GetKeyDown(KeyCode.Z)){
                player_Anim.Punch_1();
        }
        if(Input.GetKeyDown(KeyCode.X)){
                player_Anim.Kick_1();
        }
    }
}
