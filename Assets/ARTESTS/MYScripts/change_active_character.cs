using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_active_character : MonoBehaviour
{
    public GameObject Spartan;
    public GameObject Guardian;

    public AudioSource HaloAudio;
    public AudioSource DestinyAudio;

    bool isSpartan = true;

    public bool Swap()
    {
        isSpartan = !isSpartan;

        Spartan.SetActive(isSpartan);

        Guardian.SetActive(!isSpartan);

        return isSpartan;
    }

    public void playAnimation(string trigger)
    {
        Spartan.GetComponent<Animator>().SetTrigger(trigger);
        Guardian.GetComponent<Animator>().SetTrigger(trigger);
    }

    private bool isaudio = true;

    public void Toggleaudio()
    {
        if (isaudio == true)
        {
            HaloAudio.volume = 0;
            DestinyAudio.volume = 0;
        }
        else
        {
            HaloAudio.volume = 0.5f;
            DestinyAudio.volume = 0.5f;
        }
        isaudio = !isaudio;
    }
}
