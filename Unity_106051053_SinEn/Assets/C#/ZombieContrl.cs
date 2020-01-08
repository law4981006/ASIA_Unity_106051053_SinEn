using UnityEngine;

public class ZombieContrl : MonoBehaviour
{
    #region 欄位區域
    Rigidbody ZombieRidge;
    Animator ZombiAnime;

    [Tooltip("移動速度")][Range(1,100)]
    public float speed;
    [Tooltip("旋轉速度")][Range(1.5f,200f)]
    public float turnSpeed;
    #endregion

    #region 方法區域
    /// <summary>
    /// 跑步方法
    /// </summary>
    private void Run()
    {

    }

    /// <summary>
    /// 旋轉方法
    /// </summary>
    private void Turn()
    {

    }

    /// <summary>
    /// 撿東西方法
    /// </summary>
    private void PickUp()
    {

    }
    #endregion

    void Start()
    {

    }
}
