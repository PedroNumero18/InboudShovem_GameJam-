using UnityEngine;
enum phase{
        PHASE1,
        PHASE2,
        PHASE3,
}
public class BossStrenght : MonoBehaviour{
    public int damage = 1;
    [SerializeField] private phase Phase = phase.PHASE1;

    private void attackPhase1(){

    }
    private void attackPhase2(){

    }
    private void attackPhase3(){

    }
    void Update()
    {
        while (Phase == phase.PHASE1)
        {
            attackPhase1();
        }
        //entre 2 phase
        while (Phase == phase.PHASE2)
        {
            attackPhase2();
        } 
        //entre 2 phase
        while (Phase == phase.PHASE3){
            attackPhase3();
        } 
    }
}
