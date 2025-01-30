using UnityEngine;


public class HealWizardMoves : MonoBehaviour
{
    public EnemyHpController enemyHpController;
    public PlayerHpController playerHpController;
    
    public FromHealSwitchController fromHealSwitchController;
    public TurnScript turnScript;
    public GameObject healButton;

     public HitEffect hitEffect;

    public void Heal(){
        if(turnScript.currentBattleState == turnScript.possibleBattleStates[0]){
            playerHpController.PlayerHeal(50f); 
            healButton.SetActive(false);
            fromHealSwitchController.IncreaseSwitchCharge(100f);
            hitEffect.PlayerHealEffect();
            Invoke("SwitchTurn", 0.7f);
        }
    }

    private void SwitchTurn(){
         turnScript.currentBattleState = turnScript.possibleBattleStates[1];
    }
}
