using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttack : MonoBehaviour
{
    public RangedWeapons activeItem;
    public GameObject projectilePrefab;

    public Transform weaponTransform, gunTip, target;

    float timeSinceActive, reloadTime, reloadDelay;
    bool reloading;
    public bool canShoot;

    public void setTarget(Transform what)
    {
        target = what;
    }

    private void Update()
    {
        Reload();
        timeSinceActive += Time.deltaTime;

        if (canShoot && timeSinceActive >= activeItem.useRate)
        {
            Shoot(activeItem);
        }
    }

    public void Shoot(RangedWeapons shootThis)
    {
        if (target == null)
            return;

        timeSinceActive = 0;

        shootThis.setClip(shootThis.clipCurrent - shootThis.bulletCount);

        for (int i = 0; i < shootThis.bulletCount; i++)
        {
            Vector3 dir = (target.position - gunTip.position).normalized;

            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            float spread = Random.Range(-shootThis.bulletSpread, shootThis.bulletSpread);

            Quaternion projectileRotation = Quaternion.Euler(new Vector3(0, 0, angle + spread));

            GameObject projectile = (GameObject)GameObject.Instantiate(projectilePrefab, gunTip.position, projectileRotation);
            projectile.GetComponent<Projectile>().Setup(shootThis.damage, shootThis.bulletSpeed, shootThis.speedFallOff, shootThis.projectileSprite, this.gameObject.tag, this.gameObject.layer);
            // Debug.Log(this.gameObject);
        }
        //muzzleFlash.intensity = 2.5f;
        //Cam.Shake((transform.position - gunTip.position).normalized, 1.5f, 0.05f); //call camera shake for recoil
    }
    void Reload()
    {
        //reloadScript.reloading = reloading;
        //if (input.reload && activeItem != null && !reloading)
        //{
        if (activeItem.clipCurrent < activeItem.clipSize)
        {
            reloadTime = 0;
            reloading = true;
        }
        //}
        if (reloading)
        {
            reloadDelay = activeItem.reloadTime;
            if (activeItem.clipCurrent > 0) reloadDelay -= 0.5f;
            reloadTime += Time.deltaTime;

            //reloadSlider.maxValue = reloadDelay;
            //reloadSlider.value = reloadTime;

            if (reloadTime > reloadDelay)
            {
                if (activeItem.clipCurrent > 0)
                {
                    activeItem.setClip(activeItem.clipSize + activeItem.bulletCount);
                }
                else
                {
                    activeItem.setClip(activeItem.clipSize);
                }
                reloading = false;
                //reloadSlider.value = 0;
            }
        }
    }
}
