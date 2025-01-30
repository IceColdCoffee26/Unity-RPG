using UnityEngine;
using UnityEngine.UI;

public class EnemyHpController : MonoBehaviour
{
    public Image enemyHealthBar;
    public float healthAmount = 100f;

    public PlayerHpController playerHpController;

    public GameObject devai;

    public void EnemyTakeDamage (float damage){
        healthAmount -= damage;
        enemyHealthBar.fillAmount = healthAmount / 100f;
    }

    public void EnemyHeal(float healAmount){
        healthAmount += healAmount;
        healthAmount = Mathf.Clamp(healthAmount,0,100);
        enemyHealthBar.fillAmount = healthAmount / 100f;
    }

        void Update(){
        if(healthAmount <=0){
            devai.SetActive(false);
        }
    }
}
