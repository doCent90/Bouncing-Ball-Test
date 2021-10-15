using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ShowCredits : MonoBehaviour
{
    private Animator _animator;

    private const string _animationText = "SlideUp";

    public void PlayAnimation()
    {
        _animator.SetTrigger(_animationText);
    }

    private void OnEnable()
    {
        _animator = GetComponent<Animator>();
    }
}
