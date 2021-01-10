using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : Character {
    public override void DealDamage(float val)
    {
	    var ai = GetComponent<AIAgent>();
	    if(ai!=null){
		    GameLogic.instance.RemoveChaser();
		    ai.OnShotStart();
		    audioSource.PlayOneShot(AudioManager.getInstance().playerHit);
		}
    }
}
