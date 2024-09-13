using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMKOC.Sorting{
public class CloudUI : Singleton<CloudUI>
{
    private Animator m_Animator;

    protected override void Awake()
    {
        base.Awake();
        m_Animator = GetComponent<Animator>();
    }

    public void OnCloudAnimationFinished()
    {
        Gamemanager.Instance.LoadNextLevel(LevelManager.Instance.CurrentLevelIndex + 1);
    }

    public void PlayColoudEnterAnimation()
    {
        m_Animator.SetTrigger("entry");
    }

    public void PlayColoudExitAnimation()
    {
        m_Animator.SetTrigger("exit");

    }
    
}
}
