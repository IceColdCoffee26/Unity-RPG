using UnityEngine;
using UnityEngine.UI;

public class PlayerHpController : MonoBehaviour
{
    public Image playerHealthBar;
    public float healthAmount = 100f;

    public GameObject baseWizard;
    public GameObject healWizard;

    public EnemyHpController enemyHpController;

    public void PlayerTakeDamage (float damage){
        healthAmount -= damage;
        playerHealthBar.fillAmount = healthAmount / 100f;
    }

    public void PlayerHeal(float healAmount){
        healthAmount += healAmount;
        healthAmount = Mathf.Clamp(healthAmount,0,100);
        playerHealthBar.fillAmount = healthAmount / 100f;
    }

    void Update(){
        if(healthAmount <=0){
            baseWizard.SetActive(false);
            healWizard.SetActive(false);
        }
    }
}
