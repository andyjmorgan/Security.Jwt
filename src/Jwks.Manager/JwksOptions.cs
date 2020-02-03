namespace Jwks.Manager
{
    public class JwksOptions
    {
        public Algorithm Algorithm { get; set; } = Algorithm.ES256;
        public int DaysUntilExpire { get; set; } = 90;
    }
}