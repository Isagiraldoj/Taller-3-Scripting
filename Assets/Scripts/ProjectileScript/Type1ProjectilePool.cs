using UnityEngine;

public class Type1ProjectilePool : AbstractProjectilePool
{
    public static Type1ProjectilePool Instance;

    protected override void Start()
    {
        base.Start();
        Instance = this;
    }
}
