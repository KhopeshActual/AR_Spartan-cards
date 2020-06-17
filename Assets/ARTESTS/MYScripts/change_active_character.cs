using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_active_character : MonoBehaviour
{
    public GameObject Spartan;
    public GameObject Guardian;

    bool isSpartan = true;

    public void Swap()
    {
        isSpartan = !isSpartan;

        Spartan.SetActive(isSpartan);

        Guardian.SetActive(!isSpartan);

    }

    public void playAnimation(string trigger)
    {
        Spartan.GetComponent<Animator>().SetTrigger(trigger);
        Guardian.GetComponent<Animator>().SetTrigger(trigger);
    }
}
