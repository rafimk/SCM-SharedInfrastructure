using System;

namespace SCM.Shared.Infrastructure.Security.Encryption;

[AttributeUsage(AttributeTargets.Property)]
public class EncryptedAttribute : Attribute
{
}