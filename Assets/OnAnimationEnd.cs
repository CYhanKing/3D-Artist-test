using UnityEngine;
using UnityEngine.Events;

public class OnAnimationEnd : MonoBehaviour
{
    Animator a;

    public UnityEvent e;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (a.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !a.IsInTransition(0))
        {
            e.Invoke();
        }
    }
}