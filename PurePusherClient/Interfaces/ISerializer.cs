﻿namespace PurePusher.Interfaces
{
    public interface ISerializer
    {
        T Deserialize<T>(string json);

        byte[] Serialize(object obj);
    }
}
