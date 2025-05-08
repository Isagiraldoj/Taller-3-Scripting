using UnityEngine;

public class Type3ProjectilePool : AbstractProjectilePool
{
    public static Type3ProjectilePool Instance;

    protected override void Start()
    {
        base.Start();
        Instance = this;
    }
}
