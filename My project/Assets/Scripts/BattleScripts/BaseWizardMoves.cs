using UnityEngine;

public class BaseWizardMoves : MonoBehaviour
{
    public EnemyHpController enemyHpController;
    public PlayerHpController playerHpController;
    public FromBaseSwitchController fromBaseSwitchController;
    public TurnScript turnScript;

    public HitEffect hitEffect;
    

    private int canHit = 0;

    public void FireBall(){
        if(turnScript.currentBattleState == turnScript.possibleBattleStates[0] && canHit == 0){
            hitEffect.PlayerHit();
            transform.position = new Vector3(-2.6f,0,0);
            enemyHpController.EnemyTakeDamage(10f);
            fromBaseSwitchController.IncreaseSwitchCharge(25f);
            canHit = 1;
            Invoke("SwitchTurn",.7f);
        }
    }

    public void Scorch(){
        if(turnScript.currentBattleState == turnScript.possibleBattleStates[0] && canHit == 0){
            hitEffect.PlayerHit();
            hitEffect.EnemyHit();
            transform.position = new Vector3(-2.6f,0,0);
            playerHpController.PlayerTakeDamage(10f);
            enemyHpController.EnemyTakeDamage(25f);
            fromBaseSwitchController.IncreaseSwitchCharge(50f);
            canHit = 1;
            Invoke("SwitchTurn",.7f);
        }
    }

    void SwitchTurn(){
        canHit = 0;
        transform.position = new Vector3(-2.89f,0,0);
        turnScript.currentBattleState = turnScript.possibleBattleStates[1];
    }
}
