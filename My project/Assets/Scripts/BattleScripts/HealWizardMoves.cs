using System.Diagnostics;
using UnityEngine;


public class HealWizardMoves : MonoBehaviour
{
    public EnemyHpController enemyHpController;
    public PlayerHpController playerHpController;
    
    public FromHealSwitchController fromHealSwitchController;
    public TurnScript turnScript;
    public GameObject healButton;

    public HitEffect hitEffect;

    public ParticleSystem poisonActiveEffect;

    public PoisonScript poisonScript;

    public void Heal(){
        if(turnScript.currentBattleState == turnScript.possibleBattleStates[0]){
            playerHpController.PlayerHeal(50f); 
            healButton.SetActive(false);
            fromHealSwitchController.IncreaseSwitchCharge(100f);
            hitEffect.PlayerHealEffect();
            Invoke("SwitchTurn", 0.7f);
        }
    }

    public void Poison(){
        if(turnScript.currentBattleState == turnScript.possibleBattleStates[0]){
            transform.position = new Vector3(-2.6f,0,0);
            poisonActiveEffect.Play();
            poisonScript.isPoisonActive = true;
            fromHealSwitchController.IncreaseSwitchCharge(100f);
            Invoke("SwitchTurn",.7f);
        }

    }

    

    private void SwitchTurn(){
         turnScript.currentBattleState = turnScript.possibleBattleStates[1];
        transform.position = new Vector3(-2.89f,0,0);
    }
}
