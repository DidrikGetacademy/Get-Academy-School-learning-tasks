﻿namespace ChatAsIntroToDependencyInversion.Server
{
    public interface IChatClient
    {
        void Receive(string message);
    }
}
