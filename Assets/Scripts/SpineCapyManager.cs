using UnityEngine;
using UnityEngine.UI;

public class SpineCapyManager : MonoBehaviour
{
    public Dropdown dropdown1;
    public Dropdown dropdown2;
    public Dropdown dropdown3;
    public Dropdown dropdown4;
    public SpineCapyController spineCapyHeadState;
    public SpineCapyController spineCapyBodyState;
    public SpineCapyController spineCapyLegState;

    public void GetDropdownValue1()
    {
        int index = dropdown1.value;
        string selectedOption = dropdown1.options[index].text;

        if (selectedOption == "Idle")
        {
            spineCapyHeadState.SetIdleAnimation();
            spineCapyBodyState.SetIdleAnimation();
            spineCapyLegState.SetIdleAnimation();
        }
        if (selectedOption == "Walk")
        {
            spineCapyHeadState.SetWalkAnimation();
            spineCapyBodyState.SetWalkAnimation();
            spineCapyLegState.SetWalkAnimation();
        }
        if (selectedOption == "Run")
        {
            spineCapyHeadState.SetRunAnimation();
            spineCapyBodyState.SetRunAnimation();
            spineCapyLegState.SetRunAnimation();
        }
        if (selectedOption == "Jump")
        {
            spineCapyHeadState.SetJumpAnimation();
            spineCapyBodyState.SetJumpAnimation();
            spineCapyLegState.SetJumpAnimation();
        }
        if (selectedOption == "Combo")
        {
            spineCapyHeadState.StartCoroutine("SetWalkRunBrake");
            spineCapyBodyState.StartCoroutine("SetWalkRunBrake");
            spineCapyLegState.StartCoroutine("SetWalkRunBrake");
        }
    }
    public void GetDropdownValue2()
    {
        int index = dropdown2.value;
        string selectedOption = dropdown2.options[index].text;

        if (selectedOption == "Default")
        {
            spineCapyHeadState.SetDefaultSkin();
        }
        if (selectedOption == "Dinosaur")
        {
            spineCapyHeadState.SetDinosaurSkin();
        }
    }
    public void GetDropdownValue3()
    {
        int index = dropdown3.value;
        string selectedOption = dropdown2.options[index].text;

        if (selectedOption == "Default")
        {
            spineCapyBodyState.SetDefaultSkin();
        }
        if (selectedOption == "Dinosaur")
        {
            spineCapyBodyState.SetDinosaurSkin();
        }
    }
    public void GetDropdownValue4()
    {
        int index = dropdown4.value;
        string selectedOption = dropdown2.options[index].text;

        if (selectedOption == "Default")
        {
            spineCapyLegState.SetDefaultSkin();
        }
        if (selectedOption == "Dinosaur")
        {
            spineCapyLegState.SetDinosaurSkin();
        }
    }
}
