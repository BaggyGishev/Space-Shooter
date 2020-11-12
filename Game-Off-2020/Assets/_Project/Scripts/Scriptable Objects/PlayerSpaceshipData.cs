﻿using UnityEngine;


[CreateAssetMenu(fileName = "Player Spaceship Data", menuName = "Scriptable Objects/Game/Create Player Spaceship Data", order = 1)]
public class PlayerSpaceshipData : ScriptableObject
{
    [Header("Movement")]
    [SerializeField] private float thrustAccelerationSpeed;
    [SerializeField] private float thrustMaxSpeed;
    [SerializeField] private float steeringSpeed;

    public float ThrustAccelerationSpeed { get => thrustAccelerationSpeed; set => thrustAccelerationSpeed = Mathf.Max(value, 0); }
    public float ThrustMaxSpeed { get => thrustMaxSpeed; set => thrustMaxSpeed = Mathf.Max(value, 0); }
    public float SteeringSpeed { get => steeringSpeed; set => steeringSpeed = Mathf.Max(value, 0); }
}
