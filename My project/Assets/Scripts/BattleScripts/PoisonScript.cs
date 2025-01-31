using UnityEngine;

public class PoisonScript : MonoBehaviour
{
    public bool isPoisonActive;

    public TurnScript turnScript;
    public EnemyHpController enemyHpController;

     public HitEffect hitEffect;

    bool canHit = true;

    void Start(){
        isPoisonActive = false;
    }

    void Update(){
        if(isPoisonActive == true && turnScript.currentBattleState == turnScript.possibleBattleStates[2] && canHit == true){
            enemyHpController.EnemyTakeDamage(10f);
            hitEffect.PoisonEffect();
            canHit = false;
            Invoke("SwitchTurn",.7f);
        }
        else if(turnScript.currentBattleState == turnScript.possibleBattleStates[2]){
            turnScript.currentBattleState = turnScript.possibleBattleStates[0];
        }
    }

    void SwitchTurn(){
        turnScript.currentBattleState = turnScript.possibleBattleStates[0];
        canHit = true;
    }
}
