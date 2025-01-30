using UnityEngine;
using UnityEngine.UI;

public class FromHealSwitchController : MonoBehaviour
{
    public Image SwitchBar;
    public float switchAmount = 0;

    public GameObject baseWizard;
    public GameObject baseWizardHud;

    public GameObject healWizard;
    public GameObject healWizardHud;


    public void IncreaseSwitchCharge(float switchCharge){
        switchAmount += switchCharge;
        switchAmount = Mathf.Clamp(switchAmount,0,100);
        SwitchBar.fillAmount = switchAmount / 100f;
    }
    
    public void SwitchFromHeal(){
        if(switchAmount >=100){
            baseWizard.SetActive(true);
            baseWizardHud.SetActive(true);
            healWizard.SetActive(false);
            healWizardHud.SetActive(false);
            switchAmount = 0;
            SwitchBar.fillAmount = switchAmount / 100f;
        }
    }
}
