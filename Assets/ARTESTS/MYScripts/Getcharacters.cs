using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Getcharacters : MonoBehaviour
{

    public string[] SpartanAnimations;
    public string[] GuardianAnimations;
    public TMP_Dropdown animations;

    public void Start()
    {
        SetAnimDropdown(true);
    }
    public void Audiotoggle()
    {
        FindObjectOfType<change_active_character>().Toggleaudio();
    }

    public void swap()
    {
        bool isSpartan = FindObjectOfType<change_active_character>().Swap();
        SetAnimDropdown(isSpartan);
    }


    public void Picker(int i)
    {
        FindObjectOfType<change_active_character>().playAnimation(animations.options[i].text);

    }

    private void SetAnimDropdown(bool isSpartan)
    {
        animations.options.Clear();


        if (isSpartan == true)
        {
            foreach (string Anim in SpartanAnimations)
            {
                animations.options.Add(new TMP_Dropdown.OptionData(Anim));

            }
        }
        else
        {
            foreach (string Anim in GuardianAnimations)
            {
                animations.options.Add(new TMP_Dropdown.OptionData(Anim));

            }
        }
    }

}
