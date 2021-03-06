using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArchiEugene.UserProp
{
    [Serializable]
    public class UserProp
    {
        public string name;
        public int cost;
    }

    /// <summary>
    /// UserProp의 위치 정보를 저장
    /// 각도는 오일러 각으로 저장
    /// </summary>
    [Serializable]
    public class PropTransform
    {
        public int propIndex;
        public float positionX;
        public float positionY;
        public float positionZ;
        public float rotationX;
        public float rotationY;
        public float rotationZ;

        public PropTransform(int index, Vector3 position, Quaternion rotation)
        {
            propIndex = index;
            positionX = position.x;
            positionY = position.y;
            positionZ = position.z;

            var eulerRotation = rotation.eulerAngles;
            rotationX = eulerRotation.x;
            rotationY = eulerRotation.y;
            rotationZ = eulerRotation.z;
        }
    }
    
    [Serializable]
    public class UserPropData : ILoader<int, UserProp>
    {
        public List<UserProp> userProps = new List<UserProp>();
        
        public Dictionary<int, UserProp> MakeDict()
        {
            var index = 0; // 0-based index
            var dict = new Dictionary<int, UserProp>();
            foreach (var userProp in userProps)
            {
                dict.Add(index, userProp);
                index++;
            }
            return dict;
        }
    }
    
    [Serializable]
    public class PropTransformData : ILoader<int, PropTransform>
    {
        public List<PropTransform> userProps = new List<PropTransform>();
        
        public Dictionary<int, PropTransform> MakeDict()
        {
            var index = 0; // 0-based index
            var dict = new Dictionary<int, PropTransform>();
            foreach (var userProp in userProps)
            {
                dict.Add(index, userProp);
                index++;
            }
            return dict;
        }

        public PropTransformData(List<PropTransform> userProps)
        {
            this.userProps = userProps;
        }
    }
}
