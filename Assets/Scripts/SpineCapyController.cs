using Spine.Unity;
using System;
using System.Collections;
using UnityEngine;

public class SpineCapyController : MonoBehaviour
{
    [SpineAnimation]
    public string idleAnimationName;

    [SpineAnimation]
    public string walkAnimationName;

    [SpineAnimation]
    public string runAnimationName;

    [SpineAnimation]
    public string jumpAnimationName;

    [SpineAnimation]
    public string lyingIdleAnimationName;

    [SpineAnimation]
    public string lyingAnimationName;

    [SpineAnimation]
    public string swimFastAnimationName;

    [SpineAnimation]
    public string swimSlowAnimationName;

    [SpineAnimation]
    public string bornAnimationName;

    [SpineAnimation]
    public string hoverAnimationName;

    [SpineAnimation]
    public string drinkAnimationName;

    [SpineAnimation]
    public string eyeOpenAnimationName;

    [Header("Transitions")]
    [SpineAnimation]
    public string walkTransAnimationName;

    [SpineAnimation]
    public string runTransAnimationName;

    [SpineAnimation]
    public string swimTransAnimationName;

    [SpineAnimation]
    public string bornTransAnimationName;

    [SpineAnimation]
    public string brakeTransAnimationName;

    [Header("Skins")]
    [SpineSkin]
    public string defaultSkinName;
    [SpineSkin]
    public string dinosaurSkinName;

    private SkeletonAnimation skeletonAnimation;
    public Spine.AnimationState spineAnimationState;
    public Spine.Skeleton skeleton;

    void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();
        spineAnimationState = skeletonAnimation.AnimationState;
        skeleton = skeletonAnimation.Skeleton;

        //StartCoroutine(SetWalkRunBrake());
    }
    public IEnumerator SetWalkRunBrake()
    {
        spineAnimationState.SetAnimation(0, walkAnimationName, true);
        yield return new WaitForSeconds(2f);
        spineAnimationState.SetAnimation(0, runTransAnimationName, false);
        spineAnimationState.AddAnimation(0, runAnimationName, true, 0);
        yield return new WaitForSeconds(2f);
        spineAnimationState.AddAnimation(0, brakeTransAnimationName, false, 0);
        spineAnimationState.AddAnimation(0, idleAnimationName, true, 0);
        yield return null;
    }

    public void SetIdleAnimation()
    {
        spineAnimationState.SetAnimation(0, idleAnimationName, true);
    }
    public void SetWalkAnimation()
    {
        spineAnimationState.SetAnimation(0, walkAnimationName, true);
    }
    public void SetRunAnimation()
    {
        spineAnimationState.SetAnimation(0, runAnimationName, true);
    }
    public void SetJumpAnimation()
    {
        spineAnimationState.SetAnimation(0, jumpAnimationName, true);
    }
    public void SetLyingIdleAnimation()
    {
        spineAnimationState.SetAnimation(0, lyingIdleAnimationName, true);
    }
    public void SetLyingAnimation()
    {
        spineAnimationState.SetAnimation(0, lyingAnimationName, true);
    }
    public void SetSwimFastAnimation()
    {
        spineAnimationState.SetAnimation(0, swimFastAnimationName, true);
    }
    public void SetSwimSlowAnimation()
    {
        spineAnimationState.SetAnimation(0, swimSlowAnimationName, true);
    }
    public void SetBornAnimation()
    {
        spineAnimationState.SetAnimation(0, bornAnimationName, true);
    }
    public void SetHoverAnimation()
    {
        spineAnimationState.SetAnimation(0, hoverAnimationName, true);
    }
    public void SetDrinkAnimation()
    {
        spineAnimationState.SetAnimation(0, drinkAnimationName, true);
    }
    public void SetEyeOpenAnimation()
    {
        spineAnimationState.SetAnimation(0, eyeOpenAnimationName, true);
    }

    //transition
    public void SetWalkTransAnimation()
    {
        spineAnimationState.SetAnimation(0, walkTransAnimationName, true);
    }
    public void SetRunTransAnimation()
    {
        spineAnimationState.SetAnimation(0, runTransAnimationName, true);
    }
    public void SetSwimTransAnimation()
    {
        spineAnimationState.SetAnimation(0, swimTransAnimationName, true);
    }
    public void SetBornTransAnimation()
    {
        spineAnimationState.SetAnimation(0, bornTransAnimationName, true);
    }
    public void SetBrakeTransAnimation()
    {
        spineAnimationState.SetAnimation(0, brakeTransAnimationName, true);
    }

    //Setskin
    public void SetDefaultSkin()
    {
        skeleton.SetSkin(defaultSkinName);
    }
    public void SetDinosaurSkin()
    {
        skeleton.SetSkin(dinosaurSkinName);
    }
}
