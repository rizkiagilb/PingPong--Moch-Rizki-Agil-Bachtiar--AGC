using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxPowerUpAmount;
    public int spawnInterval;
    public Vector2 SpawnPos_Min;
    public Vector2 SpawnPos_Max;

    public List<GameObject> powerUpTemplateList;

    private List<GameObject> powerUpList;

    private float timer;

    public bool isPU_active;
    private float PU_fx_cooldown_current;
    private float PU_fx_cooldown_max;
    private string typePU;

    public BallControl ball;
    public PaddleManager paddle;

    


    private void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
    }
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateRandomPowerUp();
            timer -= spawnInterval;
        }









        if (PU_fx_cooldown_max > 0)
        {
            PU_fx_cooldown_current += Time.deltaTime;
            isPU_active = true;
        }
        if (PU_fx_cooldown_current >= PU_fx_cooldown_max && isPU_active == true)
        {
            PU_fx_cooldown_max = 0;
            PU_fx_cooldown_current = PU_fx_cooldown_max;
            isPU_active = false;
            ResetFxPU();
            
        }


    }

    public void setfxcdnull()
    {
        if (isPU_active == true)
        {
            PU_fx_cooldown_current = PU_fx_cooldown_max;
        }
        
    }

    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(SpawnPos_Min.x, SpawnPos_Max.x), Random.Range(SpawnPos_Min.y, SpawnPos_Max.y)));
    }

    public void GenerateRandomPowerUp(Vector2 position)
    {
        if (powerUpList.Count >= maxPowerUpAmount)
        {
            return;
        }

        if (position.x < SpawnPos_Min.x ||
            position.x > SpawnPos_Max.x ||
            position.y < SpawnPos_Min.y ||
            position.y > SpawnPos_Max.y)
        {
            return;
        }
        int randomIndex = Random.Range(0, powerUpTemplateList.Count);
        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.y), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        powerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }


    public void setType(string type)
    {
        typePU = type;
    }

    public void setCdMax(float max)
    {
        PU_fx_cooldown_max = max;
    }

    public void ResetFxPU()
    {
        if (typePU == "SpeedUP")
        {
            //speed up
            Debug.Log("Reset Speedup masuk...");
            ball.res_spup();
        }
        else if (typePU == "SpeedDown")
        {
            ball.res_spdn();
        }
        else if (typePU == "Expand")
        {
            paddle.res_expnd();
        }
        else if (typePU == "SpeedupPaddle")
        {
            paddle.res_spd_pdl();
        }
        typePU = "";
    }



}
