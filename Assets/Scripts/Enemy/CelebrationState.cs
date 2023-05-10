using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CelebrationState : State
{
    private int _celebrationHash = Animator.StringToHash("Celebration");

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play(_celebrationHash);
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}