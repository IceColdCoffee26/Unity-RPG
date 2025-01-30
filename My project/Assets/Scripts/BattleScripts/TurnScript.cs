using UnityEngine;
using UnityEngine.UI;

public class TurnScript : MonoBehaviour
{
    public string[] possibleBattleStates = {"PlayerTurn", "EnemyTurn", "Win", "Lose"};
    public string currentBattleState;
    void Start()
    {
        currentBattleState = possibleBattleStates[0];
    }
}
