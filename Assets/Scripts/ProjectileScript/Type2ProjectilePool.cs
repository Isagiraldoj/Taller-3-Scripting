using UnityEngine;

public class Type2ProjectilePool : AbstractProjectilePool
{
    public static Type2ProjectilePool Instance;

    protected override void Start()
    {
        base.Start();
        Instance = this;
    }
}
