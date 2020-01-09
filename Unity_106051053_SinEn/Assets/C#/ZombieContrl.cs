using UnityEngine;

public class ZombieContrl : MonoBehaviour
{
    #region 欄位區域
    public Rigidbody ZombieRidge;
    public Animator ZombiAnime;

    [Tooltip("移動速度")][Range(0.1f,10f)]
    public float speed;
    [Tooltip("旋轉速度")][Range(0.1f,200f)]
    public float turnSpeed;
    #endregion

    #region 方法區域
    /// <summary>
    /// 跑步方法
    /// </summary>
    private void Run()
    {
        if (Input.GetButton("Vertical"))
        {
            transform.Translate(0, 0, speed * Input.GetAxis("Vertical") * Time.deltaTime);
            ZombiAnime.SetFloat("MoveSpeed", Input.GetAxis("Vertical"));
        }
    }

    /// <summary>
    /// 旋轉方法
    /// </summary>
    private void Turn()
    {
        if (Input.GetButton("Horizontal"))
        {
            transform.Rotate(0,turnSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0);
        }
    }

    /// <summary>
    /// 攻擊方法
    /// </summary>
    private void Attack()
    {
        if (Input.GetButton("Fire1"))
        {
            ZombiAnime.SetTrigger("Attack");
            Debug.Log("Fire");
        }
    }

    /// <summary>
    /// 撿東西方法
    /// </summary>
    private void PickUp()
    {

    }
    #endregion

    void Update()
    {
        Run();
        Turn();
        Attack();
    }
}
