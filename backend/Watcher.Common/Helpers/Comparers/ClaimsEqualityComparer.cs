namespace Watcher.Common.Helpers.Comparers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Claims;
    public class ClaimsEqualityComparer : EqualityComparer<Claim>
    {
        /// <summary>When overridden in a derived class, determines whether two objects of type <typeparamref name="T">T</typeparamref> are equal.</summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>true if the specified objects are equal; otherwise, false.</returns>
        public override bool Equals(Claim x, Claim y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;

            return x.Type == y.Type 
                   && x.Value == y.Value
                   && x.Issuer == y.Issuer;
        }

        /// <summary>When overridden in a derived class, serves as a hash function for the specified object for hashing algorithms and data structures, such as a hash table.</summary>
        /// <param name="obj">The object for which to get a hash code.</param>
        /// <returns>A hash code for the specified object.</returns>
        /// <exception cref="T:System.ArgumentNullException">The type of <paramref name="obj">obj</paramref> is a reference type and <paramref name="obj">obj</paramref> is null.</exception>
        public override int GetHashCode(Claim obj)
        {
            unchecked
            {
                // Choose large primes to avoid hashing collisions
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ (obj.Type?.GetHashCode() ?? 0);
                hash = (hash * HashingMultiplier) ^ (obj.Value?.GetHashCode() ?? 0);
                hash = (hash * HashingMultiplier) ^ (obj.Issuer?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}
