using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Getcharacters : MonoBehaviour
{


    private void Start()
    {
        foreach(string Anim in SpartanAnimations)
        {
            animations.options.Add(new TMP_Dropdown.OptionData(Anim));

        }
    }


    public void swap()
    {
        FindObjectOfType<change_active_character>().Swap();
    }

    public string[] SpartanAnimations;
    public TMP_Dropdown animations;


    public void Picker(int i)
    {
        FindObjectOfType<change_active_character>().playAnimation(animations.options[i].text);

    }



}
