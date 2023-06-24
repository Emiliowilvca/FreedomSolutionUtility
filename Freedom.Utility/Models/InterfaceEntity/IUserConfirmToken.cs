using System;

namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IUserConfirmToken
    {
        int Id { get; set; }

        DateTime ExpireKey { get; set; }

        string Token { get; set; }

        Guid UserId { get; set; }

        long VerificationCode { get; set; }
    }
}