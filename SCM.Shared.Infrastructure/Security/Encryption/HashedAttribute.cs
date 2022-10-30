using System;

namespace SCM.Shared.Infrastructure.Security.Encryption;

[AttributeUsage(AttributeTargets.Property)]
public class HashedAttribute : Attribute
{
}