using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : Character {
    public override void DealDamage(float val)
    {
        base.DealDamage(val);
        
        audioSource.PlayOneShot(AudioManager.getInstance().playerHit);

        base.DealDamage(val);

        var ai = GetComponent<AIAgent>();
        print("enemy");
        ai.OnDrainStart();
    }
}
