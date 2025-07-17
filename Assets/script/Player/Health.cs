using System;
using UnityEngine;

public class Health : MonoBehaviour{
    private int maxHeart = 5;
    public int Heart;
    [SerializeField] private bool isNoHit;
    void Start()
    {
        Heart = 3;
        isNoHit = true;
    }
    public void DamageTaken(int nbDamage){
        Heart -= nbDamage;
        isNoHit = false;
        Heart = Mathf.Clamp(Heart, 0, maxHeart);
        if (Heart == 0)
        {
            playerDeath();
        }
    }
    public bool IsDead(){
        if (Heart == 0)
        {
            return true;
        }
        return false;
    }
    private void playerDeath()
    {
        SpriteRenderer playerBody = GetComponentInChildren<SpriteRenderer>();
        PlayerMovement pm = GetComponent<PlayerMovement>();
        pm.enabled = false;
        playerBody.enabled = false;
        Debug.Log("player is death");
    }
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Boss")){
            BossStrenght bossStats = collision.gameObject.GetComponent<BossStrenght>();
            DamageTaken(bossStats.damage);
        }
    }
}
