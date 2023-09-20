using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace Dots.JobsScripting
{
    public struct ClosestAndLast
    {
        public int first;
        public int second;
        public int third;
        public int last;
    }
}