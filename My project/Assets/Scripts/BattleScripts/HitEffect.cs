using UnityEngine;

public class HitEffect : MonoBehaviour
{
    public Animator camAnim;
    public ParticleSystem bloodEffect;
    public ParticleSystem playerBloodEffect;
    public ParticleSystem playerHealEffect;

    public ParticleSystem poisonEffect;
    public void PlayerHit(){
        camAnim.SetTrigger("Shake");
        bloodEffect.Play();
    }
    public void EnemyHit(){
        camAnim.SetTrigger("Shake");
        playerBloodEffect.Play();
    }
    public void PlayerHealEffect(){
        camAnim.SetTrigger("Shake");
        playerHealEffect.Play();
    }

    public void PoisonEffect(){
        camAnim.SetTrigger("Shake");
        poisonEffect.Play();
    }
}
