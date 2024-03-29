namespace src.Shared.Infrastructure
{
    using System;
    using Domain;

    public class SystemUuidGenerator : UuidGenerator
    {
        public string Generate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}