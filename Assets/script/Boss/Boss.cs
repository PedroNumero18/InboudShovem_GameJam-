using UnityEngine;
enum phase{
        PHASE1,
        PHASE2,
        PHASE3,
}
public class Boss : MonoBehaviour
{
    private int damage = 1;
    [SerializeField] private phase Phase = phase.PHASE1;

    private void attackPhase1()
    {

    }
    private void attackPhase2()
    {

    }
    private void attackPhase3(){

    }
    void Update(){
        
    }
}
