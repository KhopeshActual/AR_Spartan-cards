using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Getcharacters : MonoBehaviour
{

    public string[] SpartanAnimations;
  //  public string[] GuardianAnimations;
    public TMP_Dropdown animations;


    private void Start()
    {
        foreach(string Anim in SpartanAnimations)
        {
            animations.options.Add(new TMP_Dropdown.OptionData(Anim));

        }

       /* foreach (string Anim in GuardianAnimations)
        {
            animations.options.Add(new TMP_Dropdown.OptionData(Anim));

        }*/
    }


    public void swap()
    {
        FindObjectOfType<change_active_character>().Swap();
    }


    public void Picker(int i)
    {
        FindObjectOfType<change_active_character>().playAnimation(animations.options[i].text);

    }



}
