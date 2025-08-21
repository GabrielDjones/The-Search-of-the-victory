using UnityEngine;

public class movimento : MonoBehaviour
{
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MoveAnimationLogic(movement);

    }

    void MoveAnimationLogic(Vector2 moveSpeed)
    {
        if (moveSpeed.y != 0)
        {
            animator.Play("player walk foward");
            return;
        }
        animator.Play("idle");
    }
}
