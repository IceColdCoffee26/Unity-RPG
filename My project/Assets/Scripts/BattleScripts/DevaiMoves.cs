using UnityEngine;

public class DevaiMoves : MonoBehaviour
{
    public PlayerHpController playerHpController;
    public TurnScript turnScript;
    public HitEffect hitEffect;

    private int canHit = 0;


    // Update is called once per frame
    void Update()
    {
        if(turnScript.currentBattleState == turnScript.possibleBattleStates[1] && canHit == 0){
            hitEffect.EnemyHit();
            transform.position = new Vector3(2.6f,0,0);
            playerHpController.PlayerTakeDamage(10f);
            canHit = 1;
            Invoke("SwitchTurn",.7f);
        }
    }

    void SwitchTurn(){
        turnScript.currentBattleState = turnScript.possibleBattleStates[2]; 
        transform.position = new Vector3(2.89f,0,0);
        canHit = 0;  
    }
}
