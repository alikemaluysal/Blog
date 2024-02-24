﻿using Domain.Entities;
using NArchitecture.Core.Security.Hashing;
using NArchitecture.Core.Test.Application.FakeData;

namespace StarterProject.Application.Tests.Mocks.FakeDatas;

public class UserFakeData : BaseFakeData<User, Guid>
{
    public static Guid[] Ids = [Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()];

    public override List<User> CreateFakeData()
    {
        HashingHelper.CreatePasswordHash("123456", out byte[] passwordHash, out byte[] passwordSalt);

        List<User> data =
        [
            new User
            {
                Id = Ids[0],
                Email = "example@alikemaluysal.com",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                CreatedDate = DateTime.Now,
            },
            new User
            {
                Id = Ids[1],
                Email = "example2@alikemaluysal.com",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                CreatedDate = DateTime.Now,
            },
            new User
            {
                Id = Ids[2],
                Email = "example3@alikemaluysal.com",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                CreatedDate = DateTime.Now,
            }
        ];
        return data;
    }
}
