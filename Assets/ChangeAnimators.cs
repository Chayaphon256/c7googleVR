using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimators : MonoBehaviour
{
    // Start is called before the first frame update
    public void getCapoeira(){
        this.GetComponent<Animator>().Play("Capoeira");
    }
    public void getDancingTwerk(){
        this.GetComponent<Animator>().Play("Dancing Twerk");
    }
}
